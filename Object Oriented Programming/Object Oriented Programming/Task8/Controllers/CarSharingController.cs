namespace Task8.Controllers
{
    using System;

    using Microsoft.AspNetCore.Mvc;

    using Task8.Models;
    using Task8.Models.Web;

    /// <summary>
    /// The car sharing controller.
    /// </summary>
    public class CarSharingController : Controller
    {
        private readonly PriceSettings priceSettings;

        public CarSharingController(PriceSettings priceSettings)
        {
            this.priceSettings = priceSettings;
        }

        /// <summary>
        /// The index.
        /// </summary>
        /// <returns>
        /// The <see cref="IActionResult"/>.
        /// </returns>
        [HttpGet]
        public IActionResult Index()
        {
            return this.View();
        }

        [HttpPost]
        public string Index(CarSharingFormViewModel formModel)
        {
            if (formModel.ClientAge == 0 || formModel.DriveKm == 0 || formModel.DriveMins == 0
                || formModel.TariffType == 0)
            {
                return "Проверьте введеные значения!";
            }

            try
            {
                var tariff = TariffFactory.GetTariff(this.priceSettings, formModel);



                return this.BuildFilterString(formModel) + $"\nОбщая цена поездки: {tariff.GetPrice(km: formModel.DriveKm, min: formModel.DriveMins)}";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        private string BuildFilterString(CarSharingFormViewModel formModel)
        {
            var result = $"Выбран тариф {formModel.TariffType}";

            result += $" длительность поездки {formModel.DriveMins} минут(ы),"
                      + $" дальность поездки {formModel.DriveKm} км,";

            if (formModel.UseGps || formModel.AddDriver)
            {
                result += $" дополнительные услуги: " + (formModel.UseGps ? "GPS" : string.Empty)
                    + (formModel.AddDriver && formModel.UseGps ? " , " : string.Empty)
                    + (formModel.AddDriver ? "Личный водитель" : string.Empty);
            }

            if (formModel.ClientAge <= 21)
            {
                result += ", общая стоимость увеличена на 10% в связи с возрастом водителя";
            }

            return result;
        }
    }
}