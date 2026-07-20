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
    internal class Program
    {
        static void Main(string[] args)
        {
         

        }
    }
}
