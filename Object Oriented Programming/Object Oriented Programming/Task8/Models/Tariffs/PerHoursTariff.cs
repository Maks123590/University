namespace Task8.Models.Tariffs
{
    using System;

    using Task8.Models.Extensions;

    public class PerHoursTariff : ITariff, IMayHaveGps, IMayHaveDriver
    {
        private readonly bool addGps;
        private readonly bool addDriver;

        public PerHoursTariff(int basePricePerKm, int pricePerHour, int driverAge, bool addGps, bool addDriver)
        {
            if (driverAge < 18 || driverAge > 65)
            {
                throw new ArgumentException("Возраст должен быть в диапазоне от 18 до 65");
            }

            var surcharge = driverAge <= 21 ? 1.1 : 1;

            this.PricePerKm = basePricePerKm * surcharge;
            this.PricePerHour = pricePerHour * surcharge;

            this.addGps = addGps;
            this.addDriver = addDriver;
        }

        public double PricePerKm { get; }

        public double PricePerHour { get; }

        public double GetPrice(double km, int min)
        {
            var hours = min / 60;

            if (min % 60 > 0)
            {
                hours++;
            }

            var resultPrice = (this.PricePerKm * km) + (hours * this.PricePerHour);

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