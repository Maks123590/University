namespace WordInteractionLab8.Models.Interfaces
{
    public interface IDbChanger
    {
        void AddOrganizationToDb(OrganizationInfo organizationInfo);

        void AddBankAccountToDb(BankAccount bankAccount);

        void AddPaymentOrderToDb(Payment paymentOrder);


        void ChangeOrganizationInDb(OrganizationInfo newOrganizationInfo);

        void ChangeBankAccountInDb(BankAccount newBankAccount);

        void ChangePaymentOrderInDb(Payment newPaymentOrder);


        void RemoveOrganizationFromDb(OrganizationInfo newOrganizationInfo);

        void RemoveBankAccountFromDb(BankAccount newBankAccount);

        void RemovePaymentOrderFromDb(Payment newPaymentOrder);
    }
}