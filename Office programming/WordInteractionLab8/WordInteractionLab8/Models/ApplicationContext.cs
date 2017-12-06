namespace WordInteractionLab8.Models
{
    using System.Data.Entity;

    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("PaymentsAppDb")
        { 
        }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<OrganizationInfo> Organizations { get; set; }
    }
}