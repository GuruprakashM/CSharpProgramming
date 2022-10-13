using System;
namespace FindDistance
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the Speed in Km/hr");
            int speed=int.Parse(Console.ReadLine());
            int seconds=Convert.ToInt32(Console.ReadLine());
            double distance=speed*seconds*(5/18f);
            Console.WriteLine("The Distance in Seconds\n"+distance);
        }
    }
}
