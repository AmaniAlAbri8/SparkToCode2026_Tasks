using System;
using System.Collections.Generic;
using System.Linq;

namespace Hotel_Management_System
{
    // Room class
    public class Room
    {

        public int roomNumber;
        public string roomType;
        public double pricePerNight;
        public bool isAvailable;


        // Constructor
        public Room(int number, string type, double price)
        {
            roomNumber = number;
            roomType = type;
            pricePerNight = price;
            isAvailable = true;
        }


        // Method to display room information
        public void displayRoom()
        {
            string status;

            if (isAvailable == true)
            {
                status = "Available";
            }
            else
            {
                status = "Booked";
            }


            Console.WriteLine("Room Number: " + roomNumber + " | Type: " + roomType + " | Price: OMR " + pricePerNight.ToString("0.00") + " | Status: " + status);
        }
    }
    // Guest class
    public class Guest
    {

        public string guestId;
        public string guestName;
        public string roomNumber;
        public string checkInDate;
        public int totalNights;


        // Constructor
        public Guest(string id, string name, string date, int nights)
        {
            guestId = id;
            guestName = name;
            roomNumber = "Not Assigned";
            checkInDate = date;
            totalNights = nights;
        }



        // Calculate total booking cost
        public double calculateTotalCost(double pricePerNight)
        {
            return pricePerNight * totalNights;
        }



        // Display guest information
        public void displayGuest()
        {
            Console.WriteLine("Guest ID: " + guestId + " | Name: " + guestName + " | Room: " + roomNumber + " | Check-In: " + checkInDate + " | Nights: " + totalNights);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare lists of objects
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();



            //Pre-load rooms

            rooms.Add(new Room(101, "Single", 25));
            rooms.Add(new Room(102, "Single", 30));
            rooms.Add(new Room(201, "Double", 45));
            rooms.Add(new Room(202, "Double", 50));
            rooms.Add(new Room(301, "Suite", 100));
            rooms.Add(new Room(302, "Suite", 120));



            bool exitApp = false;


            while (exitApp == false)
            {

                Console.WriteLine("=================================");
                Console.WriteLine(" GRAND VISTA HOTEL MANAGEMENT SYSTEM ");
                Console.WriteLine("=================================");

                Console.WriteLine("1. Add New Room");
                Console.WriteLine("2. Register New Guest");
                Console.WriteLine("3. Book a Room for a Guest");
                Console.WriteLine("4. View All Rooms");
                Console.WriteLine("5. View All Guests");
                Console.WriteLine("6. Search & Filter Rooms");
                Console.WriteLine("7. Guest & Booking Statistics");
                Console.WriteLine("8. Update Room Price");
                Console.WriteLine("9. Guest Lookup by Name");
                Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("0. Exit");


                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());



                switch (choice)
                {

                    // Case 1 - Add New Room
                    case 1:
                        break;


                    // Case 2 - Register New Guest
                    case 2:
                        break;


                    // Case 3 - Book a Room
                    case 3:
                        break;


                    // Case 4 - View All Rooms
                    case 4:
                        break;


                    // Case 5 - View All Guests
                    case 5:
                        break;


                    // Case 6 - Search & Filter Rooms
                    case 6:
                        break;


                    // Case 7 - Guest & Booking Statistics
                    case 7:
                        break;


                    // Case 8 - Update Room Price
                    case 8:
                        break;


                    // Case 9 - Guest Lookup by Name
                    case 9:
                        break;


                    // Case 10 - Room Type Breakdown Report
                    case 10:
                        break;



                    // Exit
                    case 0:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;


                    default:
                        Console.WriteLine("Invalid choice!");
                        break;

                }

            }

        }

    }

}

            