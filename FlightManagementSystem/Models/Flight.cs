namespace FlightManagementSystem.Models;

public class Flight
{
    public int FlightId { get; set; } //system generated
    public string FlightCode { get; set; } //user input
    public int AircraftId { get; set; } //from list
    public int PilotId { get; set; } //from list 
    public string Origin { get; set; } // user input
    public string Destination { get; set; } //user input
    public string DepartureDate { get; set; } //user input
    public string DepartureTime { get; set; } //user input
    public decimal TicketPrice { get; set; } //calculated 
    public int AvailableSeats { get; set; } //calculated
    public string Status  { get; set; } //(Scheduled | Departed | Cancelled)
}