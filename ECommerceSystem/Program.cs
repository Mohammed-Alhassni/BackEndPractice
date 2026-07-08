

using System.Security.Cryptography;
using System.Text;

namespace ECommerceSystem
{
    public class Program
    {
        //statruc in memory context, accesible by all
        public static ECommerceContext DbContext = new ECommerceContext();

        public static void DelayedMessage(string msg, int delay = 2000)
        {
            //delay console clear so the message can stay longer 
            Console.WriteLine(msg);
            Thread.Sleep(delay);
        }

        public static string MaskInput()
        {
            // Masked password input logic
            string masked = "";
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter) break;
                if (key.Key == ConsoleKey.Backspace && masked.Length > 0)
                {
                    masked = masked[..^1];
                    Console.Write("\b \b");
                }

                else if (!char.IsControl(key.KeyChar))
                {
                    masked += key.KeyChar;
                    Console.Write("*");
                }
            }
            return masked;
        }

        public static string QuickHash(string input)
        {
            //empty string will not be hashed, then it will be detected in validation
            if (input == "") { return ""; }

            // Convert string text into raw bytes
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            // Compute the SHA256 hash bytes
            byte[] hashBytes = SHA256.HashData(inputBytes);

            // Convert the bytes into a readable, clean hex string
            return Convert.ToHexString(hashBytes);
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
                               
                               1. Register New User
                               2. 
                               3. 
                               4. 
                               5. 
                               6. 
                               7. 
                               8. 
                               0. Exit 
                               """);

                Console.Write("select option: ");
                option = int.Parse(Console.ReadLine() ?? "0");

                switch (option)
                {
                    case 1:
                        RegisterUser();
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        
                        break;
                    case 0:
                        interacting = false;
                        break;
                }

            }
        }

        public static void RegisterUser()
        {
            Console.Write("Enter username: ");
            string userName = Console.ReadLine() ?? "";
            Console.Write("Enter email: ");
            string email = Console.ReadLine() ?? "";
            Console.Write("Enter password: ");
            string passwordHash = QuickHash(MaskInput());
            Console.Write("Enter full name: ");
            string fullName = Console.ReadLine() ?? "";
        }

        static void Main(string[] args)
        {
            HomeMenu();
        }
    }
}
