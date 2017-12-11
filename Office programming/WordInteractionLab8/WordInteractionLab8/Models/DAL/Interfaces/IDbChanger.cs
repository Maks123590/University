namespace WordInteractionLab8.Models.Interfaces
{
    public interface IDbChanger
    {
        void AddOrganizationToDb(OrganizationInfo organizationInfo);

        void AddBankAccountToDb(BankAccount bankAccount);

        void AddPaymentOrderToDb(Payment paymentOrder);


        void RemoveOrganizationFromDb(OrganizationInfo organizationInfo);

        void RemoveBankAccountFromDb(BankAccount bankAccount);

        void RemoveOrderFromDb(Payment paymentOrder);
    }
}