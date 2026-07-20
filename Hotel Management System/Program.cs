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


            Console.WriteLine(
                "Room Number: " + roomNumber +
                " | Type: " + roomType +
                " | Price: OMR " + pricePerNight.ToString("0.00") +
                " | Status: " + status
            );
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
            Console.WriteLine(
                "Guest ID: " + guestId +
                " | Name: " + guestName +
                " | Room: " + roomNumber +
                " | Check-In: " + checkInDate +
                " | Nights: " + totalNights
            );
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
         

        }
    }
}
