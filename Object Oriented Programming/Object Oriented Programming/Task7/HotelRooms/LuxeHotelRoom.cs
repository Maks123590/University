namespace Task7.HotelRooms
{
    using Task7.AdditionalServices;

    public class LuxeHotelRoom : HotelRoomBase
    {
        public LuxeHotelRoom(AdditionalServiceBase services) : base(3000, services)
        {
        }
    }
}