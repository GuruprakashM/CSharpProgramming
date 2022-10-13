using System;
using System.Linq;
using System.Globalization;
namespace DaysOfMonth 
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the Month");
            DateTime month= new DateTime();
            DateTime date=new DateTime();
            month=DateTime.ParseExact(Console.ReadLine(),"MM",null);
            Console.WriteLine($"ente the year");
            DateTime year=new DateTime();
            year=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
            date=DateTime.ParseExact((month.ToString("MM")+"/"+year.ToString("yyyy")),"MM/yyyy",null);
            TimeSpan time = new TimeSpan();
            time=date.AddMonths(1).Subtract(date);
            Console.WriteLine($"{time.TotalDays} Days");
            
        }
    }
}
