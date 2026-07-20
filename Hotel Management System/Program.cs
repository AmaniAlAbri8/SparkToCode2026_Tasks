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

                        Console.Write("Enter room number: ");
                        int roomNumber = int.Parse(Console.ReadLine());


                        
                        bool roomExists = rooms.Any(r => r.roomNumber == roomNumber);


                        if (roomExists)
                        {
                            Console.WriteLine("Room already exists!");
                            break;
                        }


                        Console.Write("Enter room type (Single / Double / Suite): ");
                        string roomType = Console.ReadLine();


                        Console.Write("Enter price per night: ");
                        double price = double.Parse(Console.ReadLine());


                        if (price <= 0)
                        {
                            Console.WriteLine("Invalid price!");
                            break;
                        }



                        // Create new Room object
                        Room newRoom = new Room(roomNumber, roomType, price);


                        // Add object to rooms list
                        rooms.Add(newRoom);



                        Console.WriteLine("Room added successfully!");
                        Console.WriteLine("Room Number: " + roomNumber);
                        Console.WriteLine("Type: " + roomType);
                        Console.WriteLine("Price: OMR " + price.ToString("0.00"));
                        Console.WriteLine("Total Rooms: " + rooms.Count());


                        break;



                    // Case 2 - Register New Guest
                    case 2:


                        Console.Write("Enter guest name: ");
                        string guestName = Console.ReadLine();


                        Console.Write("Enter check-in date: ");
                        string checkInDate = Console.ReadLine();


                        Console.Write("Enter number of nights: ");
                        int nights = int.Parse(Console.ReadLine());


                        if (nights <= 0)
                        {
                            Console.WriteLine("Invalid number of nights!");
                            break;
                        }

                        
                        string guestId = "G" + (guests.Count() + 1).ToString("000");


                        // Create Guest object
                        Guest newGuest = new Guest(
                            guestId,
                            guestName,
                            checkInDate,
                            nights
                        );

                        // Add guest to list
                        guests.Add(newGuest);


                        Console.WriteLine("Guest Registered Successfully!");
                        Console.WriteLine("Guest ID: " + guestId);
                        Console.WriteLine("Name: " + guestName);
                        Console.WriteLine("Check-in Date: " + checkInDate);
                        Console.WriteLine("Total Nights: " + nights);


                        break;


                    // Case 3 - Book a Room for a Guest
                    case 3:


                        Console.Write("Enter guest ID: ");
                        string searchGuestId = Console.ReadLine();


                        Guest selectedGuest = guests.FirstOrDefault(
                            g => g.guestId == searchGuestId
                        );


                        if (selectedGuest == null)
                        {
                            Console.WriteLine("Guest not found!");
                            break;
                        }


                        Console.Write("Enter room number: ");
                        int selectedRoomNumber = int.Parse(Console.ReadLine());


                        Room selectedRoom = rooms.FirstOrDefault(
                            r => r.roomNumber == selectedRoomNumber
                        );


                        if (selectedRoom == null)
                        {
                            Console.WriteLine("Room not found!");
                            break;
                        }



                        if (selectedRoom.isAvailable == false)
                        {
                            Console.WriteLine("Room is already booked.");
                            break;
                        }


                        
                        selectedGuest.roomNumber = selectedRoomNumber.ToString();

                        selectedRoom.isAvailable = false;



                        double totalCost = selectedGuest.calculateTotalCost(
                            selectedRoom.pricePerNight
                        );



                        Console.WriteLine("Booking Successful!");

                        Console.WriteLine("Guest Name: " + selectedGuest.guestName);
                        Console.WriteLine("Room Number: " + selectedRoom.roomNumber);
                        Console.WriteLine("Room Type: " + selectedRoom.roomType);
                        Console.WriteLine("Price Per Night: OMR "
                            + selectedRoom.pricePerNight.ToString("0.00"));

                        Console.WriteLine("Total Nights: "
                            + selectedGuest.totalNights);

                        Console.WriteLine("Total Cost: OMR "
                            + totalCost.ToString("0.00"));


                        break;


                    // Case 4 - View All Rooms
                    case 4:


                        // Count number of rooms
                        int totalRooms = rooms.Count();



                        if (totalRooms == 0)
                        {
                            Console.WriteLine("No rooms have been added yet.");
                            break;
                        }



                        Console.WriteLine("===== ALL ROOMS =====");

                        Console.WriteLine("Total Rooms: " + totalRooms);

                        
                        List<Room> orderedRooms = rooms
                            .OrderBy(r => r.roomNumber)
                            .ToList();


                      
                        var roomDetails = orderedRooms
                            .Select(r => new
                            {
                                Number = r.roomNumber,
                                Type = r.roomType,
                                Price = r.pricePerNight,
                                Status = r.isAvailable ? "Available" : "Booked"
                            })
                            .ToList();



                        foreach (var room in roomDetails)
                        {

                            Console.WriteLine(
                                "Room Number: " + room.Number +
                                " | Type: " + room.Type +
                                " | Price: OMR " + room.Price.ToString("0.00") +
                                " | Status: " + room.Status
                            );

                        }



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

            