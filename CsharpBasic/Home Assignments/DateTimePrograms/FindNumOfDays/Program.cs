using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace FindNumofDays
{
    class Program 
    {
        public static void Main(string[] args)
        {
           CultureInfo provider=CultureInfo.CreateSpecificCulture("en-US");
            Console.WriteLine("Enter the date1 format dd/MM/yyyy ");
             DateTime date1=new DateTime();
             date1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",provider);
            Console.WriteLine("Enter the date2 format dd/MM/yyyy ");
             DateTime date2=new DateTime();
            date2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",provider);
            TimeSpan time=new TimeSpan();
            Console.WriteLine($"{date1}");
            
              while(date1 <= date2 )
              {
               time=(date1)-date1.AddYears(-1);
           
               
               if(time.TotalDays==365)
               {
               Console.WriteLine($"The Number of Days in{date1.ToShortDateString()} is: {time.TotalDays} Days");
               }
               else
               {
                 Console.WriteLine($"The Number of Days in{date1.ToShortDateString()} is: {time.TotalDays} Days(leap)");
               }
               
                date1=date1.AddYears(1);
                
              }
            

        }
    }
}
