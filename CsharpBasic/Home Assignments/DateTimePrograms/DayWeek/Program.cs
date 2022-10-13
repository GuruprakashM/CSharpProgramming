using System;
using System.Linq;
namespace DayWeek 
{
    class Program 
    {
        public static void Main(string[] args)
        {

            DateTime date = new DateTime();
            Console.WriteLine($"Enter the Date Format dd/MM/yyyy ");
            bool test=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:sss",null,System.Globalization.DateTimeStyles.None,out date);
            
            DayOfWeek dw= date.DayOfWeek;
            Console.WriteLine($"The date of {date.ToShortDateString()} is {dw}");
            Console.WriteLine($"The date of {date.ToLongDateString()} is {dw}");
              Console.WriteLine($"The date of {date.ToShortTimeString()} is {dw}");
                Console.WriteLine($"The date of {date.ToLongTimeString()} is {dw}");
                Console.WriteLine($"{date.ToString("dd/MM/yyyy")}");
                
            

        }
    }
}
