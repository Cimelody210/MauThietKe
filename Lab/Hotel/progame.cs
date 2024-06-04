using System;
using System.IO;
using System.Collections.Generic;

namespace Hotel
{
    public class HotelManager
    {
        private static HotelManager _instance;
        private Dictionary<int, Room> rooms;

        // Private constructor to prevent instantiation from outside
        private HotelManager()
        {
            rooms = new Dictionary<int, Room>();
        }

        // Static method to get the singleton instance
        public static HotelManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new HotelManager();
            }
            return _instance;
        }

        public void AddRoom(int roomNumber, string roomType, decimal price)
        {
            if (!rooms.ContainsKey(roomNumber))
            {
                rooms.Add(roomNumber, new Room(roomType, price));
                Console.WriteLine($"Room {roomNumber} added successfully.");
            }
            else
            {
                Console.WriteLine($"Room {roomNumber} already exists.");
            }
        }

        public void RemoveRoom(int roomNumber)
        {
            if (rooms.ContainsKey(roomNumber))
            {
                rooms.Remove(roomNumber);
                Console.WriteLine($"Room {roomNumber} removed successfully.");
            }
            else
            {
                Console.WriteLine($"Room {roomNumber} does not exist.");
            }
        }

        public Room GetRoomInfo(int roomNumber)
        {
            if (rooms.ContainsKey(roomNumber))
            {
                return rooms[roomNumber];
            }
            else
            {
                return null;
            }
        }

        public decimal CalculatePayment(int roomNumber, int numberOfDays)
        {
            if (rooms.ContainsKey(roomNumber))
            {
                Room room = rooms[roomNumber];
                // Giả sử tính giá tiền theo số ngày
                return room.Price * numberOfDays;
            }
            else
            {
                Console.WriteLine($"Room {roomNumber} does not exist.");
                return 0;
            }
        }
    }
    public class Room
    {
        public string Type { get; }
        public decimal Price { get; }

        public Room(string type, decimal price)
        {
            Type = type;
            Price = price;
        }
    }

    // phương thức CalculatePayment đã được thêm vào lớp HotelManager, cho phép tính toán số tiền cần thanh toán cho một loại phòng cụ thể trong một số ngày nhất định.
    public class Program
    {
        public static void Main(string[] args)
        {
            // Sử dụng Singleton HotelManager
            HotelManager hotelManager1 = HotelManager.GetInstance();
            hotelManager1.AddRoom(101, "Single", 50);
            hotelManager1.AddRoom(102, "Double", 80);

            // không tạo ra một instance mới, sử dụng instance đã có
            HotelManager hotelManager2 = HotelManager.GetInstance();
            Console.WriteLine(hotelManager1 == hotelManager2); // True

            hotelManager2.RemoveRoom(101);

            // Kiểm tra thông tin phòng
            Console.WriteLine(hotelManager1.GetRoomInfo(101)); // null
            Console.WriteLine(hotelManager1.GetRoomInfo(102)); // Room{Type=Double, Price=80}

            // Thanh toán
            int roomNumber = 102;
            int numberOfDays = 3;
            decimal payment = hotelManager1.CalculatePayment(roomNumber, numberOfDays);
            Console.WriteLine($"Payment for room {roomNumber} for {numberOfDays} days: {payment}");
        }
    }
}






