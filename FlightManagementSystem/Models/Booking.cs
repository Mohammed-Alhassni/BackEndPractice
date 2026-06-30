namespace FlightManagementSystem.Models;

public class Booking
{
    public int BookingId { get; set; } //system generated
    public int PassengerId { get; set; } //from list 
    public int FlightId { get; set; } //from list 
    public string SeatNumber { get; set; } //from list 
    public string BookingDate { get; set; } //user input 
    public decimal TotalPrice  { get; set; } //calculated
    public string Status { get; set; }  //(Confirmed | Cancelled)
}