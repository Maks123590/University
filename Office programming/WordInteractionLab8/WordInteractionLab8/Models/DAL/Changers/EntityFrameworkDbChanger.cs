namespace WordInteractionLab8.Models
{
    using System.Data.Entity;
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
                organization.Name = organizationInfo.Name;
                organization.CPP = organizationInfo.CPP;
                organization.INN = organizationInfo.INN;

                this.db.SaveChanges();
            }
        }

        public void ChangeBankAccountInDb(BankAccount bankAccount)
        {
            var bankAcc = this.db.BankAccounts.FirstOrDefault(ba => ba.Id == bankAccount.Id);

            if (bankAcc != null)
            {
                bankAcc.BankBic = bankAccount.BankBic;
                bankAcc.OrganizationId = bankAccount.OrganizationId;
                bankAcc.CurrentAccount = bankAccount.CurrentAccount;

                this.db.SaveChanges();
            }
        }

        public void ChangePaymentOrderInDb(Payment paymentOrder)
        {
            var payment = this.db.Payments.FirstOrDefault(ba => ba.Id == paymentOrder.Id);

            if (payment != null)
            {
                payment = paymentOrder;

                payment.DocumentDateIndicator = payment.DocumentDateIndicator;
                payment.Number = paymentOrder.Number;
                payment.PayeeAccountId = paymentOrder.PayeeAccountId;
                payment.PayeeId = paymentOrder.PayeeId;
                payment.PayerAccountId = paymentOrder.PayerAccountId;
                payment.PayerId = paymentOrder.PayerId;
                payment.Status = paymentOrder.Status;
                payment.TaxPeriodIndicatorDay = payment.TaxPeriodIndicatorDay;
                payment.TaxPeriodIndicatorMonth = payment.TaxPeriodIndicatorMonth;
                payment.TaxPeriodIndicatorYear = payment.TaxPeriodIndicatorYear;
                payment.Address = paymentOrder.Address;
                payment.Basis = paymentOrder.Basis;
                payment.Rub = paymentOrder.Rub;
                payment.Cop = paymentOrder.Cop;
                payment.CustomsCode = paymentOrder.CustomsCode;
                payment.Date = paymentOrder.Date;
                payment.Details = paymentOrder.Details;
                payment.DocumentNumberIndicator = paymentOrder.DocumentNumberIndicator;
                payment.KBK = paymentOrder.KBK;
                payment.OKTMO = paymentOrder.OKTMO;
                payment.Queue = paymentOrder.Queue;
                payment.Type = paymentOrder.Type;
                
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

        public void RemovePaymentOrderFromDb(Payment paymentOrder)
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