using System;
using System.Linq;
using System.Globalization;
namespace FormattedDated
{
    class program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the date");
            DateTime date=new DateTime();
            date=DateTime.ParseExact(Console.ReadLine(),"dd",null);
           // Console.WriteLine($"{date}");
            
            Console.WriteLine($"Enter the month");
            DateTime month = new DateTime();
            month=DateTime.ParseExact(Console.ReadLine(),"MM",null);
            //Console.WriteLine($"{month}");
            
            Console.WriteLine($"Enter the Year");
            DateTime year=new DateTime();
            year=DateTime.ParseExact(Console.ReadLine(),"yyyy",null);
            //Console.WriteLine($"{year}");
            
            DateTime dateFormat= new DateTime();
            dateFormat=DateTime.ParseExact(date.ToString("dd")+"/"+month.ToString("MM")+"/"+year.ToString("yyyy"),"dd/MM/yyyy",null);
            Console.WriteLine($"{dateFormat.ToShortDateString()}");
            
        

            
        }
    }
}
