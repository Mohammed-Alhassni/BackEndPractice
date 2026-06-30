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

    public static void DelayedMessage(string msg, int delay= 2000)
    {
        //delay console clear so the message can stay longer 
        Console.WriteLine(msg);
        Thread.Sleep(delay);
    }
        
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
        String name = Console.ReadLine().Trim();
        Console.Write("Enter Passenger Email: ");
        String email = Console.ReadLine().Trim();
        Console.Write("Enter Passenger Phone Number: ");
        String phone = Console.ReadLine().Trim();
        Console.Write("Enter Passenger Passenger Number: ");
        String passNum = Console.ReadLine().Trim();
        Console.Write("Enter Passenger Nationality: ");
        String nationality = Console.ReadLine().Trim();

        if (name == "" || email == "" || phone == "" || passNum == "")
        {
            DelayedMessage("Empty string is not valid.");
            return;
        }

        DbContext.Passengers.Add(new Passenger()
        {
            PassengerId = DbContext.Passengers.Count() + 1,
            PassengerName = name,
            PassengerEmail = email,
            PassengerPhone = phone,
            PassportNumber = passNum,
            Nationality = nationality,
        });
        
        Console.WriteLine($"Passenger Added: ID: {DbContext.Passengers.Count()}");
        //Console.WriteLine($"Passenger Added: ID: {DbContext.Passengers[DbContext.Passengers.Count()-1].PassengerId}");

        //press key to exit
        Console.Write("Press any key to continue...");
        Console.ReadKey();
    }

    public static void AddAircraft()
    {
        Console.Write("Enter Aircraft Model: ");
        string model = Console.ReadLine().Trim();
        Console.Write("Enter Total Seats: ");
        bool isValidSeat = int.TryParse(Console.ReadLine(), out int seats);

        if (model == "" || isValidSeat == false || seats <= 0)
        {
            DelayedMessage("Invalid Model or Seat number is not valid.");
            return;
        }
        
        DbContext.Aircrafts.Add(new Aircraft()
        {
            //increment id dynamically
            AircraftId = DbContext.Aircrafts.Count() + 1,
            Model = model,
            TotalSeats = seats,
        });
        
        
        //Console.WriteLine($"Aircraft Added: ID: {DbContext.Aircrafts[DbContext.Aircrafts.Count()-1].AircraftId}");
        Console.WriteLine($"Aircraft Added: ID: {DbContext.Aircrafts.Count()}");
        
        //press key to exit
        Console.Write("Press any key to continue...");
        Console.ReadKey();
    }

    public static void RegisterPilot()
    {
        Console.Write("Enter Pilot Name: ");
        string name = Console.ReadLine().Trim();
        Console.Write("Enter Pilot Phone Number: ");
        string phone = Console.ReadLine().Trim();
        Console.Write("Enter License Number: ");
        string licenseNum = Console.ReadLine().Trim();
        Console.Write("Enter Flight Hours: ");
        bool isValidflightHrs = int.TryParse(Console.ReadLine(), out int flightHrs);
        
        if (name == "" || phone == "" || licenseNum == "" ||  isValidflightHrs == false || flightHrs <= 0)
        {
            DelayedMessage("Invalid Input.");
            return;
        }
        
        DbContext.Pilots.Add(new Pilot()
        {
            //Increment dynamcally
            PilotId =  DbContext.Pilots.Count() + 1,
            PilotName = name,
            PilotPhone = phone,
            LicenseNumber = licenseNum,
            FlightHours = flightHrs,
        });
        
        //Console.WriteLine(($"Pilot Added: ID: {DbContext.Pilots[DbContext.Pilots.Count()-1].PilotId}");
        Console.WriteLine($"Pilot Added: ID: {DbContext.Pilots.Count()}");
        
        //press key to exit
        Console.Write("Press any key to continue...");
        Console.ReadKey();
    } 

    public static void ViewFlights()
    {
        //check if there is flights
        if (DbContext.Flights.Count() == 0)
        {
            DelayedMessage("No Flights Found.");
            return;
        }
        
        foreach (Flight flight in DbContext.Flights)
        {
            Console.WriteLine($"==================================================");
            Console.WriteLine($"▶ FLIGHT ID: {flight.FlightId}");
            Console.WriteLine($"==================================================");
            Console.WriteLine($"  • Code:         {flight.FlightCode}");
            Console.WriteLine($"  • Aircraft ID:  {flight.AircraftId}");
            Console.WriteLine($"  • Pilot ID:     {flight.PilotId}");
            Console.WriteLine($"  • Route:        {flight.Origin} ➔ {flight.Destination}");
            Console.WriteLine($"  • Schedule:     {flight.DepartureDate:yyyy-MM-dd} at {flight.DepartureTime}");
            Console.WriteLine($"  • Price:        ${flight.TicketPrice:N2}");
            Console.WriteLine($"  • Seats Left:   {flight.AvailableSeats}");
            Console.WriteLine($"  • Status:       {flight.Status}");
            Console.WriteLine($"==================================================\n");
            
            //press key to exit 
            Console.WriteLine("Press any key to continue...");
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