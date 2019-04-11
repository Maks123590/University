namespace Task8.Models
{
    using System.Collections.Generic;
    using System.Linq;

    using Task8.Models.Web.Enums;

    public class PriceSettings
    {
        public List<PriceItem> PriceItems { get; set; }

        public PriceItem GetPriceItemByTariffType(TariffType tariffType) => this.PriceItems.FirstOrDefault(e => e.TariffType == tariffType);
    }

    public class PriceItem
    {
        public TariffType TariffType { get; set; }

        public int PriceKm { get; set; }

        public int PriceMin { get; set; }
    }
}