namespace Task7
{
    using System;

    using Task7.AdditionalServices;
    using Task7.HotelRooms;

    public class Program
    {
        public static void Main(string[] args)
        {
            var hotelRoom = new StandartHotelRoom(new Internet(new Sofa(new BuffetBreakfast(new Dinner(new FoodDelivery())))));

            Console.WriteLine(hotelRoom.GetPrice());

            Console.ReadLine();
        }
    }
}
