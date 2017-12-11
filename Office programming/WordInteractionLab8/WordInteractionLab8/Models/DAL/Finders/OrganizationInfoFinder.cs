namespace WordInteractionLab8.Models
{
    using System.Collections.Generic;
    using System.Linq;

    using WordInteractionLab8.Models.Interfaces;

    public class OrganizationInfoFinder : IOrganizationFinder
    {
        private readonly ApplicationContext db;

        public OrganizationInfoFinder()
        {
            this.db = new ApplicationContext();
        }

        public OrganizationInfo FindOrganizationByName(string name)
        {
            return this.db.Organizations.FirstOrDefault(oInf => oInf.Name == name);
        }

        public OrganizationInfo FindByOrganizationId(int organizationId)
        {
            return this.db.Organizations.Find(organizationId);
        }

        public IEnumerable<OrganizationInfo> GetAllOrganizations()
        {
            return this.db.Organizations;
        }
    }
}