using System;
using System.Linq;
using System.Globalization;
namespace FindLeapYear 
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the year1 format yyyy");
            DateTime date1 =new DateTime();
            DateTime date2 =new DateTime();
            date1=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
            Console.WriteLine($"Enter the year2 format yyyy");
            date2=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
            //TimeSpan time=new TimeSpan();//method1 using time span
            while(date1<=date2)
            {
               /*time=date1.AddYears(1).Subtract(date1);
               if(time.TotalDays==366)
               {
                 Console.WriteLine($"{date1.ToString("yyyy")} is leap year \none year from {date1.ToShortDateString()} is {date1.AddYears(1).ToShortDateString()}");
                 
               }*/
               if(DateTime.IsLeapYear(int.Parse(date1.ToString("yyyy")))) //isLeapYear() only takes int .so we need to convert the date to string at first then int.
               {
                Console.WriteLine($"{date1.ToString("yyyy")} is leap year \none year from {date1.ToShortDateString()} is {date1.AddYears(1).ToShortDateString()}");
               }
               date1=date1.AddYears(1);
               
            }

        }
    }
}
