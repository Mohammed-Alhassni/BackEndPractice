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

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}