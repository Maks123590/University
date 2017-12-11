namespace WordInteractionLab8.Models.Interfaces
{
    using System.Collections.Generic;

    public interface IOrganizationFinder
    {
        OrganizationInfo FindOrganizationByName(string name);

        OrganizationInfo FindByOrganizationId(int organizationId);

        IEnumerable<OrganizationInfo> GetAllOrganizations();
    }
}   