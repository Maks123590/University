namespace Task8.Models.Tariffs
{
    using Task8.Models.Extensions;

    public class BaseTariff : TariffAbstract, IMayHaveGps
    {
        private readonly bool addGps;

        public BaseTariff(int basePricePerKm, int basePricePerMin, int driverAge, bool addGps) : base(basePricePerKm, basePricePerMin, driverAge)
        {
            this.addGps = addGps;
        }

        public override double GetPrice(double km, int min)
        {
            var resultPrice = base.GetPrice(km, min);

            if (this.addGps)
            {
                resultPrice += this.AddGps(min);
            }

            return resultPrice;
        }
    }
}