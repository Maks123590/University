namespace WordInteractionLab8.Models
{
    using System.Collections.Generic;
    using System.Linq;

    using WordInteractionLab8.Models.Interfaces;

    public class BankAccountFinder : IBankAccountFinder
    {
        private ApplicationContext db;

        public BankAccountFinder()
        {
            this.db = new ApplicationContext();
        }

        public IEnumerable<BankAccount> FindByOrganizationId(int organizationId)
        {
            return this.db.BankAccounts.Where(ac => ac.OrganizationId == organizationId);
        }

        public BankAccount FindById(int id)
        {
            return this.db.BankAccounts.Find(id);
        }
    }
}