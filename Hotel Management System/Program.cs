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


                        int totalGuests = guests.Count();



                        if (totalGuests == 0)
                        {
                            Console.WriteLine("No guests have been registered yet.");
                            break;
                        }



                        Console.WriteLine("===== ALL GUESTS =====");

                        Console.WriteLine("Total Guests: " + totalGuests);


                        
                        List<Guest> orderedGuests = guests
                            .OrderBy(g => g.guestName)
                            .ToList();


                        
                        var guestDetails = orderedGuests
                            .Select(g => new
                            {
                                ID = g.guestId,
                                Name = g.guestName,
                                Room = g.roomNumber,
                                Date = g.checkInDate,
                                Nights = g.totalNights
                            })
                            .ToList();



                        foreach (var guest in guestDetails)
                        {

                            Console.WriteLine(
                                "ID: " + guest.ID +
                                " | Name: " + guest.Name +
                                " | Room: " + guest.Room +
                                " | Check-In: " + guest.Date +
                                " | Nights: " + guest.Nights
                            );

                        }

                        break;

                    // Case 6 - Search & Filter Rooms
                    case 6:


                        bool backToRoomSearch = false;



                        while (backToRoomSearch == false)
                        {

                            Console.WriteLine("===== ROOM SEARCH MENU =====");

                            Console.WriteLine("1. Show all available rooms");
                            Console.WriteLine("2. Filter by room type");
                            Console.WriteLine("3. Filter by maximum price");
                            Console.WriteLine("4. Room price statistics");
                            Console.WriteLine("0. Back");


                            Console.Write("Enter choice: ");

                            int searchChoice = int.Parse(Console.ReadLine());



                            switch (searchChoice)
                            {


                                // Option 1 - Available Rooms
                                case 1:


                                   
                                    List<Room> availableRooms = rooms
                                        .Where(r => r.isAvailable == true)
                                        .OrderBy(r => r.pricePerNight)
                                        .ToList();



                                    Console.WriteLine(
                                        "Available Rooms Count: "
                                        + availableRooms.Count()
                                    );



                                    if (availableRooms.Count() == 0)
                                    {
                                        Console.WriteLine(
                                            "No rooms found for the selected criteria."
                                        );
                                        break;
                                    }



                                    foreach (Room r in availableRooms)
                                    {
                                        r.displayRoom();
                                    }


                                    break;




                                // Option 2 - Filter by Room Type
                                case 2:


                                    Console.Write("Enter room type: ");

                                    string type = Console.ReadLine();



                                    
                                    List<Room> roomsByType = rooms
                                        .Where(r => r.roomType.ToLower()
                                        == type.ToLower())
                                        .ToList();



                                    Console.WriteLine(
                                        "Rooms Found: "
                                        + roomsByType.Count()
                                    );



                                    if (roomsByType.Count() == 0)
                                    {
                                        Console.WriteLine(
                                        "No rooms found for the selected criteria."
                                        );

                                        break;
                                    }



                                    foreach (Room r in roomsByType)
                                    {
                                        r.displayRoom();
                                    }



                                    break;




                                // Option 3 - Filter by Maximum Price
                                case 3:


                                    Console.Write("Enter maximum price: ");

                                    double maxPrice = double.Parse(
                                        Console.ReadLine()
                                    );



                                    
                                    List<Room> cheapRooms = rooms
                                        .Where(r =>
                                        r.isAvailable == true
                                        && r.pricePerNight <= maxPrice)
                                        .OrderBy(r => r.pricePerNight)
                                        .ToList();


                                    Console.WriteLine( "Rooms Found: " + cheapRooms.Count() );


                                    if (cheapRooms.Count() == 0)
                                    {
                                        Console.WriteLine(
                                        "No rooms found for the selected criteria."
                                        );

                                        break;
                                    }


                                    foreach (Room r in cheapRooms)
                                    {
                                        r.displayRoom();
                                    }


                                    break;



                                // Option 4 - Room Price Statistics
                                case 4:


                                    if (rooms.Count() == 0)
                                    {
                                        Console.WriteLine( "No rooms available." );

                                        break;
                                    }


                                    int totalRoomNumber = rooms.Count();



                                    int availableRoomNumber = rooms
                                        .Count(r => r.isAvailable == true);



                                    double averagePrice = rooms
                                        .Average(r => r.pricePerNight);



                                    double cheapestPrice = rooms
                                        .Min(r => r.pricePerNight);



                                    double highestPrice = rooms
                                        .Max(r => r.pricePerNight);




                                    Console.WriteLine("===== ROOM STATISTICS =====");


                                    Console.WriteLine("Total Rooms: " + totalRoomNumber );


                                    Console.WriteLine("Available Rooms: " + availableRoomNumber );


                                    Console.WriteLine("Average Price: OMR " + averagePrice.ToString("0.00") );


                                    Console.WriteLine( "Cheapest Price: OMR " + cheapestPrice.ToString("0.00") );


                                    Console.WriteLine("Highest Price: OMR " + highestPrice.ToString("0.00") );



                                    break;




                                // Back to main menu
                                case 0:

                                    backToRoomSearch = true;

                                    break;



                                default:

                                    Console.WriteLine("Invalid choice!");

                                    break;

                            }


                        }


                        break;

                    // Case 7 - Guest & Booking Statistics
                    case 7:


                        Console.WriteLine("===== GUEST & BOOKING STATISTICS =====");



                        // Total registered guests
                        int GuestsCount = guests.Count();



                        // Guests who have rooms assigned
                        int activeGuests = guests
                            .Count(g => g.roomNumber != "Not Assigned");



                        Console.WriteLine(
                            "Total Registered Guests: "
                            + GuestsCount
                        );


                        Console.WriteLine(
                            "Guests With Booking: "
                            + activeGuests
                        );



                        // Total rooms
                        int RoomsCount = rooms.Count();



                        // Booked rooms
                        int bookedRooms = rooms
                            .Count(r => r.isAvailable == false);



                        Console.WriteLine("Total Rooms: " + RoomsCount);


                        Console.WriteLine("Booked Rooms: "+ bookedRooms );



                        // Check if there are active bookings

                        bool hasBookings = guests
                            .Any(g => g.roomNumber != "Not Assigned");



                        if (hasBookings == false)
                        {
                            Console.WriteLine("No active bookings recorded.");

                            break;
                        }


                        // Average nights of booked guests

                        double averageNights = guests
                            .Where(g => g.roomNumber != "Not Assigned")
                            .Average(g => g.totalNights);



                        Console.WriteLine( "Average Stay Nights: " + averageNights.ToString("0.00"));


                        // Top 3 highest spending guests

                        var topGuests = guests
                            .Where(g => g.roomNumber != "Not Assigned")
                            .OrderByDescending(g =>
                            {
                                Room room = rooms
                                .FirstOrDefault(r =>
                                r.roomNumber.ToString() == g.roomNumber);


                                return g.calculateTotalCost(room.pricePerNight );

                            })
                            .Take(3)
                            .ToList();


                        Console.WriteLine("===== TOP 3 HIGHEST SPENDING GUESTS =====");


                        foreach (var guest in topGuests)
                        {


                            Room room = rooms.FirstOrDefault(
                                r => r.roomNumber.ToString()
                                == guest.roomNumber
                            );



                            double cost = guest.calculateTotalCost(
                                room.pricePerNight
                            );



                            Console.WriteLine(
                                "Name: " + guest.guestName +
                                " | Room: " + guest.roomNumber +
                                " | Cost: OMR "
                                + cost.ToString("0.00")
                            );

                        }


                        // Select summary lines

                        var guestSummary = guests
                            .Where(g => g.roomNumber != "Not Assigned")
                            .Select(g =>
                            {


                                Room room = rooms.FirstOrDefault(
                                    r => r.roomNumber.ToString()
                                    == g.roomNumber
                                );


                                double cost =
                                g.calculateTotalCost(
                                    room.pricePerNight
                                );


                                return g.guestName +
                                " — Room " +
                                g.roomNumber +
                                " — " +
                                g.totalNights +
                                " nights — OMR " +
                                cost.ToString("0.00");

                            })
                            .ToList();



                        Console.WriteLine("===== BOOKING SUMMARY =====");


                        foreach (string line in guestSummary)
                        {
                            Console.WriteLine(line);
                        }


                        break;

                    // Case 8 - Update Room Price
                    case 8:


                        Console.Write("Enter room number: ");

                        int updateRoomNumber =
                            int.Parse(Console.ReadLine());




                        
                        Room updateRoom = rooms
                            .FirstOrDefault(r =>
                            r.roomNumber == updateRoomNumber);




                        if (updateRoom == null)
                        {
                            Console.WriteLine(
                            "Room not found!"
                            );

                            break;
                        }



                        Console.Write("Enter new price: ");

                        double newPrice =
                            double.Parse(Console.ReadLine());




                        if (newPrice <= 0)
                        {
                            Console.WriteLine(
                            "Invalid price!"
                            );

                            break;
                        }


                        double oldPrice = updateRoom.pricePerNight;




                        updateRoom.pricePerNight = newPrice;




                        Console.WriteLine(
                            "Room price updated successfully!"
                        );


                        Console.WriteLine(
                            "Old Price: OMR "
                            + oldPrice.ToString("0.00")
                        );


                        Console.WriteLine(
                            "New Price: OMR "
                            + newPrice.ToString("0.00")
                        );



                        break;

                    // Case 9 - Guest Lookup by Name
                    case 9:


                        Console.Write("Enter guest name to search: ");

                        string searchName = Console.ReadLine();


                        List<Guest> matchedGuests = guests
                            .Where(g => g.guestName
                            .ToLower()
                            .Contains(searchName.ToLower()))
                            .ToList();



                        Console.WriteLine(
                            "Number of Matches: "
                            + matchedGuests.Count()
                        );



                        if (matchedGuests.Count() == 0)
                        {
                            Console.WriteLine(
                            "No guests matched that search."
                            );

                            break;
                        }



                        foreach (Guest g in matchedGuests)
                        {

                            Console.WriteLine(
                                "ID: " + g.guestId +
                                " | Name: " + g.guestName +
                                " | Room: " + g.roomNumber
                            );

                        }



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

            