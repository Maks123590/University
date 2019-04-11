namespace Task8.Models
{
    using System;

    public abstract class TariffAbstract : ITariff
    {
        protected TariffAbstract(int basePricePerKm, int basePricePerMin, int driverAge)
        {
            if (driverAge < 18 || driverAge > 65)
            {
                throw new ArgumentException("Возраст должен быть в диапазоне от 18 до 65");
            }

            var surcharge = driverAge <= 21 ? 1.1 : 1;

            this.PricePerKm = basePricePerKm * surcharge;
            this.PricePerMin = basePricePerMin * surcharge;
        }

        public double PricePerKm { get; }

        public double PricePerMin { get; }

        public virtual double GetPrice(double km, int min)
        {
            return (this.PricePerKm * km) + (this.PricePerMin * min);
        }
    }
}