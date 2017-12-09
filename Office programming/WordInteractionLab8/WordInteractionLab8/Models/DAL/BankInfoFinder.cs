namespace WordInteractionLab8.Models
{
    using System.Data;

    using WordInteractionLab8.IoC;
    using WordInteractionLab8.Models.Interfaces;

    public class BankInfoFinder : IBankInfoFinder
    {
        private readonly IDbDownoader dbDownoader;

        public BankInfoFinder()
        {
            this.dbDownoader = ServiceLocator.GetService<IDbDownoader>();
        }

        public BankInfo GetBankInfoByBic(string bic)
        {
            var dataTable = this.dbDownoader.GetBankInfoTable();

            foreach (DataRow row in dataTable.Rows)
            {
                if (row[nameof(BankInfo.Bic)].ToString() == bic)
                {
                    return new BankInfo
                               {
                                   FullName = row[nameof(BankInfo.FullName)].ToString(),
                                   Bic = row[nameof(BankInfo.Bic)].ToString(),
                                   Locality = row[nameof(BankInfo.Locality)].ToString(),
                                   CorrespondentAccount = row[nameof(BankInfo.CorrespondentAccount)].ToString()
                               };
                }
            }

            return null;
        }
    }
}