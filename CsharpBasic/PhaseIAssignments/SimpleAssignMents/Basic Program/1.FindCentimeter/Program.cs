using System;
namespace FindCentimeter
{
    class Program

    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the Inch value");
            double inch=Convert.ToDouble(Console.ReadLine());
            double centimeter=inch*2.54;
            Console.WriteLine($"The centimeter of{inch} is : {centimeter} cm");
            
            
        }
    }
}
