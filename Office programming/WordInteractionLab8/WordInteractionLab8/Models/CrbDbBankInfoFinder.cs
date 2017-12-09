namespace WordInteractionLab8.Models
{
    using System.Data;
    using System.Data.Odbc;
    using System.Net;
    using System.IO.Compression;
    using System.Security;
    using System.Security.Permissions;
    using System.Xml.Linq;

    using WordInteractionLab8.Models.Interfaces;

    public class CrbDbWorker : IBankFinder
    {
        private const string SourceDbPath = @"http://www.cbr.ru/mcirabis/BIK/";

        private string bicCatalogSourcePath = @"http://www.cbr.ru/mcirabis/PluginInterface/GetBicCatalog.aspx";

        private string localDbPath = @"Data\";

        private string tempCatalogPath = @"temp\";

        private string dbName = @"bnkseek.dbf";

        public BankInfo GetBankInfoByBIC(string bic)
        {
            var dataTable = this.GetDataTable();

            foreach (DataRow row in dataTable.Rows)
            {
                if (row.ItemArray[1].ToString() == bic)
                {
                    return new BankInfo
                               {
                                   Bic = row.ItemArray[1].ToString(),
                                   FullName = row.ItemArray[0].ToString(),
                                   CorrespondentAccount = row.ItemArray[3].ToString(),
                                   Locality = row.ItemArray[2].ToString()
                    };
                }
            }

            return null;
        }

        public void UploadDb()
        {
            this.DownloadDb();
        }

        private DataTable GetDataTable()
        {
            var obdcConnection = new OdbcConnection();

            obdcConnection.ConnectionString = "Driver={Microsoft dBase Driver (*.dbf)};SourceType=DBF;SourceDB=" + this.localDbPath + ";Exclusive=No; NULL=NO;DELETED=NO;BACKGROUNDFETCH=NO;";

            obdcConnection.Open();

            var command = obdcConnection.CreateCommand();

            command.CommandText = "SELECT NAMEP, NEWNUM, NNP, KSNP FROM " + localDbPath + dbName;

            var dataTable = new DataTable();

            dataTable.Load(command.ExecuteReader());

            obdcConnection.Close();

            return dataTable;
        }

        private void DownloadDb()
        {
            var currentZipArchName = this.GetCurrentDbFileName();

            WebClient webClient = new WebClient();
            webClient.DownloadFile(SourceDbPath + currentZipArchName, this.tempCatalogPath + currentZipArchName);

            using (var zipFile = ZipFile.OpenRead(this.tempCatalogPath + currentZipArchName))
            {
                foreach (var entry in zipFile.Entries)
                {
                    if (entry.Name == this.dbName)
                    {
                        entry.ExtractToFile(this.localDbPath + this.dbName, true);
                        break;
                    }
                }
            }

            this.ProtectData();
        }

        private string GetCurrentDbFileName()
        {
            var biclistPath = this.tempCatalogPath + "biclist.xml";

            WebClient webClient = new WebClient();
            webClient.DownloadFile(this.bicCatalogSourcePath, biclistPath);

            var xdoc = XDocument.Load(biclistPath);

            return xdoc.Element("BicDBList").Element("item").Attribute("file").Value;

        }

        private void ProtectData()
        {
            PermissionSet myPerms = new PermissionSet(PermissionState.None);
            myPerms.AddPermission(new FileIOPermission(FileIOPermissionAccess.NoAccess, this.localDbPath));
            myPerms.Demand();
        }

    }
}