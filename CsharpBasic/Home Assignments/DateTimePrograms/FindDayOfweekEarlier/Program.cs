using System;
using System.Linq;
namespace FindDayofWeekEarlier
{
    class Program
    {
        public static void Main(string[] args)
        {
            TimeSpan  time =new TimeSpan();
            DateTime date=new DateTime(2022,8,16);
            time = DateTime.Now-date;
            Console.WriteLine($"{(int)time.TotalDays}");
           DayOfWeek dw=date.DayOfWeek;
           Console.WriteLine($"Today is {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss tt")}");
           
           Console.WriteLine($"40 days from today.on that day is {dw}");
           
            
        }
    }
}