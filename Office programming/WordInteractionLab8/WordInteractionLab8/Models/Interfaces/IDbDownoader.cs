namespace WordInteractionLab8.Models.Interfaces
{
    using System.Data;

    public interface IDbDownoader
    {
        DataTable GetBankInfoTable();
    }
}