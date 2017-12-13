namespace WordInteractionLab8.Models
{
    using System;
    using System.Data;
    using System.Data.Odbc;
    using System.IO;
    using System.IO.Compression;
    using System.Net;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Xml.Linq;

    using WordInteractionLab8.Models.Interfaces;

    public class CrbDbDownloader : IDbDownloader
    {
        private const string SourceDbPath = @"http://www.cbr.ru/mcirabis/BIK/";

        private const string BicCatalogSourcePath = @"http://www.cbr.ru/mcirabis/PluginInterface/GetBicCatalog.aspx";

        private const string DbName = @"bnkseek.dbf";

        private const string DbInfoName = @"dbInfo.xml";

        private readonly string localDbPath = @"Data\";

        private readonly string dbConnectionString;

        public CrbDbDownloader(string localDbPath)
        {
            this.localDbPath = localDbPath;

            if (!Directory.Exists(this.localDbPath))
            {
                Directory.CreateDirectory(this.localDbPath);
            }

            this.dbConnectionString = "Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=" + localDbPath + ";Exclusive=No; NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;";
        }

        public event EventHandler<InfoMessageEventsArgs> ShowInfoMessage;

        public bool DbFileExist => File.Exists(this.localDbPath + DbName);

        private XElement DbFileInfo { get; set; }

        public DataTable GetBankInfoTable()
        {
            return this.GetBankInfosDataTable();
        }

        public string GetCurrentDbVeresion()
        {
            if (File.Exists(this.localDbPath + DbInfoName))
            {
                var xdoc = XDocument.Load(this.localDbPath + DbInfoName);

                return xdoc.Element("item")?.Attribute("date")?.Value;
            }

            return "версия не определена";
        }

        public async Task<string> GetActualDbVersionAsync()
        {
            var infoFileElem = await this.GetDbInfoFile(false);

            return infoFileElem?.Attribute("date")?.Value;
        }

        public async void UploadDb(ProgressBar progress = null)
        {
            var currentVersion = this.GetCurrentDbVeresion();

            var actualVersion = await this.GetActualDbVersionAsync();

            if (currentVersion != actualVersion)
            {
                this.DownloadDbAsync(progress);
            }
            else
            {
                this.OnShowInfoMessage(new InfoMessageEventsArgs() { Message = "Уже загружена актуальная версия базы данных.", Type = MessageType.InfoMessage });
            }
        }

        public DataTable GetBankInfosDataTable()
        {
            var obdcConnection = new OdbcConnection { ConnectionString = this.dbConnectionString };

            obdcConnection.Open();

            var command = obdcConnection.CreateCommand();

            command.CommandText = "SELECT NAMEP, NEWNUM, NNP, KSNP FROM " + this.localDbPath + DbName;

            var dataTable = new DataTable("BankInfos");

            dataTable.Load(command.ExecuteReader());

            dataTable.Columns["NAMEP"].ColumnName = nameof(BankInfo.FullName);
            dataTable.Columns["NEWNUM"].ColumnName = nameof(BankInfo.Bic);
            dataTable.Columns["NNP"].ColumnName = nameof(BankInfo.Locality);
            dataTable.Columns["KSNP"].ColumnName = nameof(BankInfo.CorrespondentAccount);

            obdcConnection.Close();

            return dataTable;
        }

        protected virtual void OnShowInfoMessage(InfoMessageEventsArgs e)
        {
            EventHandler<InfoMessageEventsArgs> handler = this.ShowInfoMessage;

            handler?.Invoke(this, e);
        }

        private async void DownloadDbAsync(ProgressBar progress = null)
        {
            var infoFileElem = await this.GetDbInfoFile(false);

            var currentZipArchName = this.GetCurrentDbFileName(infoFileElem);

            var webClient = new WebClient();

            webClient.DownloadProgressChanged += (s, e) =>
                {
                    

                    if (progress != null)
                    {
                        progress.Visible = true;
                        progress.Value = e.ProgressPercentage;
                    }
                };
            webClient.DownloadDataCompleted += (s, e) =>
                {
                    if (progress != null)
                    {
                        progress.Visible = false;
                    }

                    var stream = new MemoryStream(e.Result);

                    using (var zipArchive = new ZipArchive(stream))
                    {
                        foreach (var entry in zipArchive.Entries)
                        {
                            if (entry.Name == DbName)
                            {
                                this.OnShowInfoMessage(new InfoMessageEventsArgs() { Message = "Сохранение на диск..", Type = MessageType.StateMessage });
                                entry.ExtractToFile(this.localDbPath + DbName, true);
                                this.SaveDbInfo(infoFileElem);

                                this.OnShowInfoMessage(new InfoMessageEventsArgs() { Message = "Готово.", Type = MessageType.StateMessageEnd });
                                break;
                            }
                        }
                    }
                };

            webClient.DownloadDataAsync(new Uri(SourceDbPath + currentZipArchName));

            this.OnShowInfoMessage(new InfoMessageEventsArgs() { Message = "Загрузка базы..", Type = MessageType.StateMessage });
        }

        private async Task<XElement> GetDbInfoFile(bool forcibly)
        {
            if (forcibly || this.DbFileInfo == null)
            {
                var webClient = new WebClient();

                this.OnShowInfoMessage(new InfoMessageEventsArgs() { Message = "Проверка актуальной версии..", Type = MessageType.StateMessage });

                var stream = await webClient.OpenReadTaskAsync(new Uri(BicCatalogSourcePath));

                var xdoc = XDocument.Load(stream);

                this.DbFileInfo = xdoc.Element("BicDBList")?.Element("item");

                this.OnShowInfoMessage(
                    new InfoMessageEventsArgs() { Message = "Готово.", Type = MessageType.StateMessageEnd });

                return this.DbFileInfo;

            }
            else
            {
                return this.DbFileInfo;
            }
        }

        private string GetCurrentDbFileName(XElement infoFileElem)
        {
            return infoFileElem.Attribute("file")?.Value;
        }

        private void SaveDbInfo(XElement item)
        {
            var xdoc = new XDocument(item);

            this.OnShowInfoMessage(new InfoMessageEventsArgs() { Message = "Сохранение на диск..", Type = MessageType.StateMessage });

            xdoc.Save(this.localDbPath + DbInfoName);
        }
    }

    public class InfoMessageEventsArgs : EventArgs
    {
        public string Message { get; set; }

        public MessageType Type { get; set; }
    }

    public enum MessageType
    {
        StateMessage,
        InfoMessage,
        StateMessageEnd
    }
}