namespace FlightManagementSystem.Models;

public class Pilot
{
    public int PilotId  { get; set; } //System generated
    public string PilotName { get; set; } //User input
    public string PilotPhone { get; set; }  //User Input
    public string LicenseNumber { get; set; } //User input
    public int FlightHours  { get; set; } //User input 
    public bool IsAvailable { get; set; } = true; //default value
}