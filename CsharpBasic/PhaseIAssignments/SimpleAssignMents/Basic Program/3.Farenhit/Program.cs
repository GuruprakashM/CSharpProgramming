using System;
namespace Farenhit
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the Celsis");
            double celsis=Convert.ToDouble(Console.ReadLine());
            double farenhit= celsis*(9/5f)+32f;
            Console.WriteLine($" The Farenhit of {celsis } is {farenhit}");
            
            
        }
    }
}