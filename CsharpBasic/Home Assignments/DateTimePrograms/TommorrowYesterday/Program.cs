using System;
using System.Linq;
using System.Globalization;
namespace TommorrowYesterday 
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            DateTime date =new DateTime();
            date=DateTime.Now;
            Console.WriteLine($"today: {date.ToShortDateString()} \ntommorrow: {date.AddDays(1).ToShortDateString()} \nyesterday: {date.AddDays(-1).ToShortDateString()}");
            
            
        }
    }
}