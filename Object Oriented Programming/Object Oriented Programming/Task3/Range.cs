namespace Task3
{
    /// <summary>
    /// Тип интервала
    /// </summary>
    public enum RangeType
    {
        /// <summary>
        /// Возрастания
        /// </summary>
        Ascending = 0,

        /// <summary>
        /// Убывания
        /// </summary>
        Descending = 1
    }

    public class Range
    {
        public double From { get; set; }

        public double To { get; set; }

        public RangeType Type { get; set; }
    }
}