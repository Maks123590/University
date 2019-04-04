namespace Task8.Models.Extensions
{
    public static class TariffExtensionMethods
    {
        public static int GpsPricePerHour { get; set; }

        public static int DriverPrice { get; set; }

        public static double AddGps(this IMayHaveGps tariff, int min)
        {
            var hours = min / 60;

            if (min % 60 > 0)
            {
                hours++;
            }

            return hours * GpsPricePerHour;
        }

        public static double AddDriver(this IMayHaveDriver tariff)
        {
            return DriverPrice;
        }
    }
}