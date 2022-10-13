using System;
using System.Linq;
using System.Globalization;
namespace ComTwodates
{
    class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo provide= CultureInfo.CreateSpecificCulture("en-US");
            Console.WriteLine($"Enter the date 1");
            DateTime date1=new DateTime();
              DateTime date2=new DateTime();
            date1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:MM:ss tt", provide);
            Console.WriteLine($"Enter the date 2");
            date2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:MM:ss tt", provide);
            TimeSpan time=new TimeSpan();
            time=date2-date1;
            if(time.TotalHours<0)
            {
                Console.WriteLine($"{date1.ToString("dd/MM/yyyy HH:mm:ss tt")} is earlier than {date2.ToString("dd/MM/yyyy HH:mm:ss tt")}");
                
            }
           else if(time.TotalHours>0) 
            {
                Console.WriteLine($"{date1.ToString("dd/MM/yyyy HH:mm:ss tt")} is later than {date2.ToString("dd/MM/yyyy HH:mm:ss tt")}");
                
            }
            else
            {
                Console.WriteLine($"{date1.ToString("dd/MM/yyyy HH:mm:ss tt")} {date2.ToString("dd/MM/yyyy HH:mm:ss tt")} both are Equels");
            }
            
            
            
        }
    }
}