namespace WordInteractionLab8.Models
{
    public class BankAccount
    {
        public int Id { get; set; }

        public int OrganizationId { get; set; }

        //public string BIC { get; set; }

        public BankInfo BankInfo { get; set; }

        public string CurrentAccount { get; set; }
    }
}