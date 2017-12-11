namespace WordInteractionLab8.Models
{
    using System.Linq;

    using WordInteractionLab8.Models.Interfaces;

    public class EntityFrameworkDbChanger : IDbChanger
    {
        private readonly ApplicationContext db;

        public EntityFrameworkDbChanger()
        {
            this.db = new ApplicationContext();
        }

        public void AddOrganizationToDb(OrganizationInfo organizationInfo)
        {
            var organization = this.db.Organizations.FirstOrDefault(org => org.Id == organizationInfo.Id);

            if (organization != null)
            {
                organization = organizationInfo;
            }
            else
            {
                this.db.Organizations.Add(organizationInfo);
            }

            this.db.SaveChanges();
        }

        public void AddBankAccountToDb(BankAccount bankAccount)
        {
            var bankAcc = this.db.BankAccounts.FirstOrDefault(ba => ba.Id == bankAccount.Id);

            if (bankAcc != null)
            {
                bankAcc = bankAccount;
            }
            else
            {
                this.db.BankAccounts.Add(bankAccount);
            }

            this.db.SaveChanges();
        }

        public void AddPaymentOrderToDb(Payment paymentOrder)
        {
            var payment = this.db.Payments.FirstOrDefault(ba => ba.Id == paymentOrder.Id);

            if (payment != null)
            {
                payment = paymentOrder;
            }
            else
            {
                this.db.Payments.Add(paymentOrder);
            }

            this.db.SaveChanges();
        }

        public void RemoveOrganizationFromDb(OrganizationInfo organizationInfo)
        {
            if (organizationInfo == null)
            {
                return;
            }

            this.db.Organizations.Remove(organizationInfo);
        }

        public void RemoveBankAccountFromDb(BankAccount bankAccount)
        {
            if (bankAccount == null)
            {
                return;
            }

            this.db.BankAccounts.Remove(bankAccount);
        }

        public void RemoveOrderFromDb(Payment paymentOrder)
        {
            if (paymentOrder == null)
            {
                return;
            }

            this.db.Payments.Remove(paymentOrder);
        }
    }
}