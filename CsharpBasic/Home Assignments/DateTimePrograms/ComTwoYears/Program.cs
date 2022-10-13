using System;
using System.Linq;
using System.Globalization;
namespace ComTwodYears 
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the date");
            DateTime date=new DateTime();
            CultureInfo provide = CultureInfo.CreateSpecificCulture("en-US");
            date=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",provide);
            TimeSpan time= new TimeSpan();
            Console.WriteLine($"Enter the compare format 1 or -1");
            int format=int.Parse(Console.ReadLine());
            if(format==1)
            {
            time=date.AddYears(1).Subtract(date);
            Console.WriteLine($"{(int)time.TotalDays}");
            Console.WriteLine($"{date.ToShortDateString()}is Earlier than {date.AddYears(1).ToShortDateString()} ");
            }
            else
            {
            time=date.AddYears(-1).Subtract(date);
            Console.WriteLine($"{(int)time.TotalDays}");
            Console.WriteLine($"{date.ToShortDateString()}is Later than {date.AddYears(-1).ToShortDateString()} ");
            }
            
            
            
        }
    }
}