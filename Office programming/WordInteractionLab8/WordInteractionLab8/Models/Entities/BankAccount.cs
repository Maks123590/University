namespace WordInteractionLab8.Models
{
    public class BankAccount
    {
        public int Id { get; set; }

        public int OrganizationId { get; set; }

        public string BankBic { get; set; }

        public string CurrentAccount { get; set; }
    }
}