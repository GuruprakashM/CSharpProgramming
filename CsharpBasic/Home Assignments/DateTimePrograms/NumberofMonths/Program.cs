using System;
using System.Linq;
using System.Globalization;
namespace NUmberofMonths 

{
    class Program 
    {
        public static void Main(string[] args)
        {
            DateTime date=new DateTime();
            DateTime date1=new DateTime();
            date=date1=DateTime.Now;
            Console.WriteLine($"Today is {date.ToShortDateString()}");
            
            while(date1<date.AddYears(1))
            {
                Console.WriteLine($"{date1.ToString("MMMM")}");
       
                date1=date1.AddMonths(1);
            }
        }
    }
}