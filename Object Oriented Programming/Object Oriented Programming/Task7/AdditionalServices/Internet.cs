namespace Task7.AdditionalServices
{
    using System;

    public class Internet : AdditionalServiceBase
    {
        public Internet(AdditionalServiceBase additionalServiceBase = null) : base(additionalServiceBase)
        {
        }

        private int Price => 100;

        public override int GetPrice(int price)
        {
            Console.WriteLine(nameof(Internet));

            return base.GetPrice(price) + this.Price;
        }
    }
}