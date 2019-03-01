namespace Task7.AdditionalServices
{
    public abstract class AdditionalServiceBase
    {
        private readonly AdditionalServiceBase additionalServiceBase;

        protected AdditionalServiceBase(AdditionalServiceBase additionalServiceBase)
        {
            this.additionalServiceBase = additionalServiceBase;
        }

        public virtual int GetPrice(int price)
        {
            if (this.additionalServiceBase != null)
            {
                price = this.additionalServiceBase.GetPrice(price);
            }

            return price;
        }
    }
}