using FlightManagementSystem.Models;

namespace FlightManagementSystem;

class Program
{
    public static FMSContext DbContext = new FMSContext()
    {
        Aircrafts = new List<Aircraft>(),
        Bookings = new List<Booking>(),
        Flights = new List<Flight>(),
        Passengers = new List<Passenger>(),
        Pilots = new List<Pilot>()
    };

    public static void HomeMenu()
    {
        bool interacting = true;
        int option;

        while (interacting)
        {
            Console.Clear();
            Console.WriteLine($"""
                               
                               1. Register a Passenger
                               2. Add an Aircraft
                               3. Register a Pilot
                               4. View All Flights
                               5. Schedule a Flight
                               6. Book a Flight
                               7. Cancel a Booking
                               8. Depart a Flight
                               
                               """); 
            
            Console.Write("select option: ");
            option = int.Parse(Console.ReadLine() ?? "0");
            
            switch (option)
            {
                case 1:

                    break;
                case 0: 
                    interacting = false;
                    break;
            }
            
        }
    }

    static void Main(string[] args)
    {
        HomeMenu();
    }
}