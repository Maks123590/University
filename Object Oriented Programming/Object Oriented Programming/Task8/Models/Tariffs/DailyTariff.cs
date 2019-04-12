namespace Task8.Models.Tariffs
{
    using System;

    using Task8.Models.Extensions;

    public class DailyTariff : ITariff, IMayHaveGps, IMayHaveDriver
    {
        private const int OneDay = 60 * 24;

        private readonly bool addGps;
        private readonly bool addDriver;

        public DailyTariff(int basePricePerKm, int pricePerDay, int driverAge, bool addGps, bool addDriver)
        {
            if (driverAge < 18 || driverAge > 65)
            {
                throw new ArgumentException("Возраст должен быть в диапазоне от 18 до 65");
            }

            var surcharge = driverAge <= 21 ? 1.1 : 1;

            this.PricePerKm = basePricePerKm * surcharge;
            this.PricePerDay = pricePerDay * surcharge;


            this.addGps = addGps;
            this.addDriver = addDriver;
        }

        public double PricePerKm { get; }

        public double PricePerDay { get; }

        public double GetPrice(double km, int min)
        {
            var days = min / OneDay;

            if (min % OneDay > 29)
            {
                days++;
            }

            if (days == 0)
            {
                days = 1;
            }

            var resultPrice = (this.PricePerKm * km) + (days * this.PricePerDay);

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