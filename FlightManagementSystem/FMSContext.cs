using FlightManagementSystem.Models;

namespace FlightManagementSystem;

public class FMSContext
{
    public List<Aircraft> Aircrafts { get; set; }
    public List<Booking> Bookings { get; set; }
    public List<Flight> Flights { get; set; }
    public List<Passenger> Passengers { get; set; }
    public List<Pilot> Pilots { get; set; }
}