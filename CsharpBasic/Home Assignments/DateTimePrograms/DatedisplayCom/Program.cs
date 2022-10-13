using System;
namespace DatedisplayCom 
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime date=new DateTime();
            bool test=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss tt",null,System.Globalization.DateTimeStyles.None,out date);
            Console.WriteLine($"{date.ToString("dd/mm/yyyy HH:mm:ss:ffff")}");
            
        }
    }
}