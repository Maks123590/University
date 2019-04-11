namespace Task8.Models
{
    using System;

    using Task8.Models.Tariffs;
    using Task8.Models.Web;
    using Task8.Models.Web.Enums;

    public static class TariffFactory
    {
        public static ITariff GetTariff(PriceSettings priceSettings, CarSharingFormViewModel data)
        {
            var priceItem = priceSettings.GetPriceItemByTariffType(data.TariffType);

            if ((data.TariffType == TariffType.Base || data.TariffType == TariffType.Student) && data.AddDriver)
            {
                throw new Exception("Водитель недоступен для данного тарифа");
            }

            switch (data.TariffType)
            {
                case TariffType.Base: return new BaseTariff(basePricePerKm: priceItem.PriceKm, basePricePerMin: priceItem.PriceMin, addGps: data.UseGps, driverAge: data.ClientAge);
                case TariffType.PerHours: return new PerHoursTariff(basePricePerKm: priceItem.PriceKm, basePricePerMin: priceItem.PriceMin, addGps: data.UseGps, driverAge: data.ClientAge, addDriver: data.AddDriver);
                case TariffType.Daily: return new DailyTariff(basePricePerKm: priceItem.PriceKm, basePricePerMin: priceItem.PriceMin, addGps: data.UseGps, driverAge: data.ClientAge, addDriver: data.AddDriver);
                case TariffType.Student: return new StudentTariff(basePricePerKm: priceItem.PriceKm, basePricePerMin: priceItem.PriceMin, addGps: data.UseGps, driverAge: data.ClientAge);
                default:
                    throw new Exception("Тариф не найден");
            }
        }


    }
}