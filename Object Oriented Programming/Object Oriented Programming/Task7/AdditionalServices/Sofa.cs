namespace Task7.AdditionalServices
{
    using System;

    public class Sofa : AdditionalServiceBase
    {
        public Sofa(AdditionalServiceBase additionalServiceBase = null) : base(additionalServiceBase)
        {
        }

        private int Price => 500;

        public override int GetPrice(int price)
        {
            Console.WriteLine(nameof(Sofa));

            return base.GetPrice(price) + this.Price;
        }
    }
}