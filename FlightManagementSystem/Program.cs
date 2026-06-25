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

    public void HomeMenu()
    {
        
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
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}