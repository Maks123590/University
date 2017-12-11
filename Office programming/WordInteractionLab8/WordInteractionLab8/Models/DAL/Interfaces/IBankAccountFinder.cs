namespace WordInteractionLab8.Models.Interfaces
{
    using System.Collections.Generic;

    public interface IBankAccountFinder
    {
        IEnumerable<BankAccount> FindBankAccountsByOrganizationId(int organizationId);
    }
}