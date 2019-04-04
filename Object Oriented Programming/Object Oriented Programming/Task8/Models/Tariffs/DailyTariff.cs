namespace Task8.Models.Tariffs
{
    using Task8.Models.Extensions;

    public class DailyTariff : TariffAbstract, IMayHaveGps, IMayHaveDriver
    {
        private readonly bool addGps;
        private readonly bool addDriver;

        public DailyTariff(int basePricePerKm, int basePricePerMin, int driverAge, bool addGps, bool addDriver) : base(basePricePerKm, basePricePerMin, driverAge)
        {
            this.addGps = addGps;
            this.addDriver = addDriver;
        }

        public override double GetPrice(double km, int min)
        {
            const int OneDay = 60 * 24;

            var days = min / OneDay;

            if (min % OneDay > 29)
            {
                days++;
            }

            var resultPrice = base.GetPrice(km, days * OneDay);

            if (this.addGps)
            {
                resultPrice += this.AddGps(min);
            }

            if (this.addDriver)
            {
                resultPrice += this.AddDriver();
            }

            return resultPrice;
        }
    }
}