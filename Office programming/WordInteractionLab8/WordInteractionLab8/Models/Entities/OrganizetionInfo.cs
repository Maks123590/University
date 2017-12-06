namespace WordInteractionLab8.Models
{
    public enum Entity
    {
        LegalPersonality,
        NaturalPerson
    }


    public class OrganizationInfo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string INN { get; set; }

        public string CPP { get; set; }

        public BankAccount[] BankAccounts { get; set; }

        public Entity Entity { get; set; }
    }
}