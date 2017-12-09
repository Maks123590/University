namespace WordInteractionLab8.Models.Interfaces
{
    public interface IBankFinder
    {
        BankInfo GetBankInfoByBIC(string bic);
    }
}