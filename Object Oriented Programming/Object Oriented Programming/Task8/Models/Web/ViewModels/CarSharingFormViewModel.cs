namespace Task8.Models.Web
{
    using Task8.Models.Web.Enums;

    public class CarSharingFormViewModel
    {
        public int ClientAge { get; set; }

        public int DriveMins { get; set; }

        public int DriveKm { get; set; }

        public TariffType TariffType { get; set; }

        public bool UseGps { get; set; }

        public bool AddDriver { get; set; }
    }
}