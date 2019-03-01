namespace Task7.HotelRooms
{
    using Task7.AdditionalServices;

    public class StandartHotelRoom : HotelRoomBase
    {
        public StandartHotelRoom(AdditionalServiceBase services) : base(2000, services)
        {
        }
    }
}