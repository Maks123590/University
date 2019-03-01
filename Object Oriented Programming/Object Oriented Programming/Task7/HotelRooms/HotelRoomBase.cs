namespace Task7.HotelRooms
{
    using System;

    using Task7.AdditionalServices;

    public abstract class HotelRoomBase
    {
        protected HotelRoomBase(int price, AdditionalServiceBase services)
        {
            this.Price = price;
            this.Services = services;
        }

        public AdditionalServiceBase Services { get; }

        protected int Price { get; set; }

        public virtual int GetPrice()
        {
            Console.WriteLine(nameof(HotelRoomBase));

            var price = this.Price;

            if (this.Services != null)
            {
                price = this.Services.GetPrice(price);
            }

            return price;
        }
    }
}