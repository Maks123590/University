namespace Task8.Models.Web.Enums
{
    using System.ComponentModel.DataAnnotations;

    public enum TariffType
    {
        [Display(Name = "базовый")]
        Base = 1,
        [Display(Name = "суточный")]
        Daily = 2,
        [Display(Name = "почасовой")]
        PerHours = 4,
        [Display(Name = "студенческий")]
        Student = 8
    }
}