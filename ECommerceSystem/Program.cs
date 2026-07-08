

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

        public static void HomeMenu()
        {
            bool interacting = true;
            int option;

            while (interacting)
            {
                //clear display before each menu render 
                Console.Clear();
                Console.WriteLine($"""
                               
                               1. 
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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
