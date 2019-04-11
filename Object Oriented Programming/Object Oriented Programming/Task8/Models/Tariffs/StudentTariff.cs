namespace Task8.Models.Tariffs
{
    using System;

    using Task8.Models.Extensions;

    public class StudentTariff : TariffAbstract, IMayHaveGps
    {
        private readonly bool addGps;

        public StudentTariff(int basePricePerKm, int basePricePerMin, int driverAge, bool addGps) : base(basePricePerKm, basePricePerMin, driverAge)
        {
            if (driverAge > 25)
            {
                throw new ArgumentException("На данном тарифе ограничение по возрасту до 25 лет");
            }

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