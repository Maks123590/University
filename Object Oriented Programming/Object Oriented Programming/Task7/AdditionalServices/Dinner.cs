namespace Task7.AdditionalServices
{
    using System;

    public class Dinner : AdditionalServiceBase
    {
        public Dinner(AdditionalServiceBase additionalServiceBase = null) : base(additionalServiceBase)
        {
        }

        private int Price => 800;

        public override int GetPrice(int price)
        {
            Console.WriteLine(nameof(Dinner));

            return base.GetPrice(price) + this.Price;
        }
    }
}