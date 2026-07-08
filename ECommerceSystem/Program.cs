

namespace ECommerceSystem
{
    public class Program
    {
        //statruc in memory context, accesible by all
        public static ECommerceContext DbContext = new ECommerceContext();


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
