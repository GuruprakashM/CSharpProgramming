using System;
namespace DateFormat 
{
    class  Program 
    {
        public static void Main(string[] args)
        {
            DateTime date =new DateTime();
           
            bool test=DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null,System.Globalization.DateTimeStyles.None,out date);
            Console.WriteLine($"The full date :{date.ToString("dd/MM//yyyy HH:mm:ss tt")}");
            Console.WriteLine($"The Short date : {date.ToShortDateString()}");
            Console.WriteLine($"The Long date: {date.ToLongDateString()}");
            Console.WriteLine($"The 12Hour Format{date.ToString("dd/MM/yyy HH:mm:ss")}");
            Console.WriteLine($"{date.ToString("dd/mm/yyyy")}");
            Console.WriteLine($"{date.ToString("HH:mm:ss tt")}");
           
            
            
            
            
            
            
            
        }
    }
}
