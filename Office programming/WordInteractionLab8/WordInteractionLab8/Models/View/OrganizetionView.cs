namespace WordInteractionLab8.Models
{
    public class OrganizationView
    {
        public string Name { get; set; }

        public string INN { get; set; }

        public string CPP { get; set; }

        public BankAccountView BankAccount { get; set; }
    }
}