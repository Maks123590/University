namespace Task7.AdditionalServices
{
    using System;

    public class FoodDelivery : AdditionalServiceBase
    {
        public FoodDelivery(AdditionalServiceBase additionalServiceBase = null) : base(additionalServiceBase)
        {
        }

        private int Price => 300;

        public override int GetPrice(int price)
        {
            Console.WriteLine(nameof(FoodDelivery));

            return base.GetPrice(price) + this.Price;
        }
    }
}