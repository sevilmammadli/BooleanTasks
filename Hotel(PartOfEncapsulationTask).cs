
using System.Security.Cryptography.X509Certificates;

namespace Project8_Encapsulation_.Classes
{
    public class Hotel
    {
        public Guid Id { get; private set; }
        public string HotelName { get; set; }
        public string Address { get; set; }

        private int _roomCount;

        private int _roomPrice;

        public Hotel()
        {
            Id = Guid.NewGuid();
        }

        public int RoomCount
        {
            get
            {
                return _roomCount;
            }
            set
            {
                if (value > 0 && value < 200)
                {
                    _roomCount = value;
                }
                else
                {
                    Console.WriteLine("Count of Room can`t be defined!");
                }
                
            }
        }
        public int RoomPrice
        {
            get
            {
                return _roomPrice;
            }
            set
            {
                if(value > 60 && value < 150)
                {
                    _roomPrice = value;
                }
                else
                {
                    Console.WriteLine("Price of Room changes between 60 and 150");
                }
                
            }
        }

        public int GetPriceRoom(int countOfRoom)
        {
            countOfRoom = _roomCount;
            return _roomPrice * countOfRoom;
        }


        public void GetHotelInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name of Hotel: {HotelName}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Count of Rooms: {RoomCount}");
            Console.WriteLine($"Price of Rooms: {RoomPrice}");

        }











    }
}
