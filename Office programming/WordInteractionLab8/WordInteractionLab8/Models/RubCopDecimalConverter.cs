namespace WordInteractionLab8.Models
{
    using System.Globalization;

    public static class RubCopDecimalConverter
    {
        public static decimal GetDecimal(int rub, int cop)
        {
            var summstr = rub + "." + cop;

            return decimal.Parse(summstr, CultureInfo.InvariantCulture);
        }
    }
}