namespace WordInteractionLab8.Models.Interfaces
{
    public interface IBankInfoFinder
    {
        BankInfo GetBankInfoByBic(string bic);
    }
}