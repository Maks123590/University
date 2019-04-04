namespace Task8.Models
{
    public interface ITariff
    {
        double GetPrice(double km, int min);
    }
}