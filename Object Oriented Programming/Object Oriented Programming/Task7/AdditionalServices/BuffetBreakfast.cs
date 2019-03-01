namespace Task7.AdditionalServices
{
    using System;

    public class BuffetBreakfast : AdditionalServiceBase
    {
        public BuffetBreakfast(AdditionalServiceBase additionalServiceBase = null) : base(additionalServiceBase)
        {
        }

        private int Price => 500;

        public override int GetPrice(int price)
        {
            Console.WriteLine(nameof(BuffetBreakfast));

            return base.GetPrice(price) + this.Price;
        }
    }
}