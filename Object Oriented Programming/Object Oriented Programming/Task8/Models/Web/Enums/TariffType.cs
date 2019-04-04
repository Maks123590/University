namespace Task8.Models.Web.Enums
{
    using System.ComponentModel.DataAnnotations;

    public enum TariffType
    {
        [Display(Name = "базовый")]
        Base = 1,
        [Display(Name = "почасовой")]
        Daily = 2,
        [Display(Name = "суточный")]
        PerHours = 4,
        [Display(Name = "студенческий")]
        Student = 8
    }
}