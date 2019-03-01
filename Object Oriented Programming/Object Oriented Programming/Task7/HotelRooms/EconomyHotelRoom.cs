namespace Task7.HotelRooms
{
    using Task7.AdditionalServices;

    public class EconomyHotelRoom : HotelRoomBase
    {
        public EconomyHotelRoom(AdditionalServiceBase services) : base(1000, services)
        {
        }
    }
}