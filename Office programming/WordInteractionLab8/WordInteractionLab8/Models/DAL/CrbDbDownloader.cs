namespace WordInteractionLab8.Models
{
    using System.Data;
    using System.Data.Odbc;
    using System.IO.Compression;
    using System.Net;
    using System.Xml.Linq;

    using WordInteractionLab8.Models.Interfaces;

    public class CrbDbDownloader : IDbDownoader
    {
        private const string SourceDbPath = @"http://www.cbr.ru/mcirabis/BIK/";

        private const string BicCatalogSourcePath = @"http://www.cbr.ru/mcirabis/PluginInterface/GetBicCatalog.aspx";

        private const string DbName = @"bnkseek.dbf";

        private readonly string localDbPath = @"Data\";

        private readonly string dbConnectionString;

        public CrbDbDownloader(string localDbPath)
        {
            this.localDbPath = localDbPath;

            dbConnectionString = "Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=" + localDbPath + ";Exclusive=No; NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;";
        }

        public DataTable GetBankInfoTable()
        {
            return this.GetBankInfosDataTable();
        }

        public void UploadDb()
        {
            // TODO test db version
            this.DownloadDb();
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

        private void DownloadDb()
        {
            var currentZipArchName = this.GetCurrentDbFileName();

            var webClient = new WebClient();

            var stream = webClient.OpenRead(SourceDbPath + currentZipArchName);

            using (var zipArchive = new ZipArchive(stream))
            {
                foreach (var entry in zipArchive.Entries)
                {
                    if (entry.Name == DbName)
                    {
                        entry.ExtractToFile(this.localDbPath + DbName, true);
                        break;
                    }
                }
            }
        }

        private string GetCurrentDbFileName()
        {
            var webClient = new WebClient();

            var stream = webClient.OpenRead(BicCatalogSourcePath);
            var xdoc = XDocument.Load(stream);

            return xdoc.Element("BicDBList")?.Element("item")?.Attribute("file")?.Value;

        }
    }
}