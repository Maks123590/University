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
            this.db.Organizations.Add(organizationInfo);

            this.db.SaveChanges();
        }

        public void AddBankAccountToDb(BankAccount bankAccount)
        {
            this.db.BankAccounts.Add(bankAccount);

            this.db.SaveChanges();
        }

        public void AddPaymentOrderToDb(Payment paymentOrder)
        {
            this.db.Payments.Add(paymentOrder);

            this.db.SaveChanges();
        }


        public void ChangeOrganizationInDb(OrganizationInfo organizationInfo)
        {
            var organization = this.db.Organizations.FirstOrDefault(org => org.Id == organizationInfo.Id);

            if (organization != null)
            {
                organization = organizationInfo;
                this.db.SaveChanges();
            }
        }

        public void ChangeBankAccountInDb(BankAccount bankAccount)
        {
            var bankAcc = this.db.BankAccounts.FirstOrDefault(ba => ba.Id == bankAccount.Id);

            if (bankAcc != null)
            {
                bankAcc = bankAccount;
                this.db.SaveChanges();
            }
        }

        public void ChangePaymentOrderInDb(Payment paymentOrder)
        {
            var payment = this.db.Payments.FirstOrDefault(ba => ba.Id == paymentOrder.Id);

            if (payment != null)
            {
                payment = paymentOrder;
                this.db.SaveChanges();
            }
        }


        public void RemoveOrganizationFromDb(OrganizationInfo organizationInfo)
        {
            if (organizationInfo == null)
            {
                return;
            }

            var organization = this.db.Organizations.FirstOrDefault(org => org.Id == organizationInfo.Id);

            if (organization != null)
            {
                this.db.Organizations.Remove(organization);
                this.db.SaveChanges();
            }
        }

        public void RemoveBankAccountFromDb(BankAccount bankAccount)
        {
            if (bankAccount == null)
            {
                return;
            }

            var bankAcc = this.db.BankAccounts.FirstOrDefault(ba => ba.Id == bankAccount.Id);

            if (bankAcc != null)
            {
                this.db.BankAccounts.Remove(bankAcc);
                this.db.SaveChanges();
            }
        }

        public void RemoveOrderFromDb(Payment paymentOrder)
        {
            if (paymentOrder == null)
            {
                return;
            }

            var payment = this.db.Payments.FirstOrDefault(p => p.Id == paymentOrder.Id);

            if (payment != null)
            {
                this.db.Payments.Remove(payment);
                this.db.SaveChanges();
            }
        }
    }
}