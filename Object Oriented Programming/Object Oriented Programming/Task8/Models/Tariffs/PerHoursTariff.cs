namespace Task8.Models.Tariffs
{
    using Task8.Models.Extensions;

    public class PerHoursTariff : TariffAbstract, IMayHaveGps, IMayHaveDriver
    {
        private readonly bool addGps;
        private readonly bool addDriver;

        public PerHoursTariff(int basePricePerKm, int basePricePerMin, int driverAge, bool addGps, bool addDriver) : base(basePricePerKm, basePricePerMin, driverAge)
        {
            this.addGps = addGps;
            this.addDriver = addDriver;
        }

        public override double GetPrice(double km, int min)
        {
            var hoursInMin = min % 60 > 0 ? ((min / 60) + 1) * 60 : min;

            var resultPrice = base.GetPrice(km, hoursInMin);

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