namespace WordInteractionLab8.Models.Interfaces
{
    public interface IPaymentOrderFinder
    {
        Payment FindPaymentOrderByNumber(string number);
    }
}