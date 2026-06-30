using FlightManagementSystem.Models;

namespace FlightManagementSystem;

class Program
{
    public static FMSContext DbContext = new FMSContext()
    {
        //in memory snapshot of for the db raws 
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
            //clear display before each menu render 
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
                    RegisterPassenger();
                    break;
                case 2:
                    AddAircraft();
                    break;
                case 3:
                    RegisterPilot();
                    break;
                case 4:
                    ViewFlights();
                    break;
                case 0: 
                    interacting = false;
                    break;
            }
            
        }
    }

    public static void RegisterPassenger()
    {
        Console.Write("Enter Passenger Name: ");
        String name = Console.ReadLine();
        Console.Write("Enter Passenger Email: ");
        String email = Console.ReadLine();
        Console.Write("Enter Passenger Phone Number: ");
        String phone = Console.ReadLine();
        Console.Write("Enter Passenger Passenger Number: ");
        String passNum = Console.ReadLine();
        Console.Write("Enter Passenger Nationality: ");
        String nationality = Console.ReadLine();
        
        DbContext.Passengers.Add(new Passenger()
        {
            PassengerId = DbContext.Passengers.Count() + 1,
            PassengerName = name,
            PassengerEmail = email,
            PassengerPhone = phone,
            PassportNumber = passNum,
            Nationality = nationality,
        });
        
        //Console.WriteLine($"Passenger Added: ID: {DbContext.Passengers[DbContext.Passengers.Count()-1].PassengerId}");
        Console.WriteLine($"Passenger Added: ID: {DbContext.Passengers.Count()}");
        //delay console clear so the message can stay longer 
        Thread.Sleep(2000);
    }

    public static void AddAircraft()
    {
        Console.Write("Enter Aircraft Model: ");
        string model = Console.ReadLine();
        Console.Write("Enter Total Seats: ");
        int seats = int.Parse(Console.ReadLine());
        
        DbContext.Aircrafts.Add(new Aircraft()
        {
            //increment id dynamically
            AircraftId = DbContext.Aircrafts.Count() + 1,
            Model = model,
            TotalSeats = seats,
        });
        
        //Console.WriteLine($"Aircraft Added: ID: {DbContext.Aircrafts[DbContext.Aircrafts.Count()-1].AircraftId}");
        Console.WriteLine($"Aircraft Added: ID: {DbContext.Aircrafts.Count()}");
        //delay console clear so the message can stay longer 
        Thread.Sleep(2000);
    }

    public static void RegisterPilot()
    {
        Console.Write("Enter Pilot Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Pilot Phone Number: ");
        string phone = Console.ReadLine();
        Console.Write("Enter License Number: ");
        string licenseNum = Console.ReadLine();
        Console.Write("Enter Flight Hours: ");
        int flightHrs = int.Parse(Console.ReadLine());
        
        DbContext.Pilots.Add(new Pilot()
        {
            PilotId =  DbContext.Pilots.Count() + 1,
            PilotName = name,
            PilotPhone = phone,
            LicenseNumber = licenseNum,
            FlightHours = flightHrs,
        });
        
        //Console.WriteLine($"Pilot Added: ID: {DbContext.Pilots[DbContext.Pilots.Count()-1].PilotId}");
        Console.WriteLine($"Pilot Added: ID: {DbContext.Pilots.Count()}");
        //delay console clear so the message can stay longer 
        Thread.Sleep(2000);
    } 

    public static void ViewFlights()
    {
        foreach (Flight flight in DbContext.Flights)
        {
            Console.WriteLine($"Flight ID: {flight.FlightId}, Flight Code: {flight.FlightCode}, Aircraft ID: {flight.AircraftId}, Pilot ID: {flight.PilotId}," +
                              $" Origin: {flight.Origin}, Destination: {flight.Destination}, Departure Date: {flight.DepartureDate}, Departure Time: {flight.DepartureTime}," +
                              $" Ticket Price: {flight.TicketPrice}, Available Seats: {flight.AvailableSeats},  Status: {flight.Status}");
            //press key to exit 
            Console.ReadKey();
        }
    }
    
    static void Main(string[] args)
    {
        //Data seed for testing 
        DbContext.Flights.Add(new Flight()
        {
            FlightId = 1,
            FlightCode = "AA-101",
            AircraftId = 1, 
            PilotId = 1,   
            Origin = "JFK",
            Destination = "LAX",
            DepartureDate= "2015",
            DepartureTime = "12am",
            TicketPrice = 250.00m, 
            AvailableSeats = 180,
            Status = "Scheduled"
        });
        
        //entry point to the app 
        HomeMenu();
    }
}