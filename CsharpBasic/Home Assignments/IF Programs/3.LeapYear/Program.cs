using System;
namespace LeapYear
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the Year");
            int year=int.Parse(Console.ReadLine());
            if(year%4==0)
            {
                Console.WriteLine($"the {year} is LEAP YEAR");
                
            }
            else
            {
                Console.WriteLine($"the is {year} is NOT LEAP YEAR");
                
            }
            
        }
    }
}
