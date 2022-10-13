using System;
namespace FindSeason
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter your Month"); 
            string month=Console.ReadLine();
            if(month=="January" || month=="Febraury" ||month=="December")
            {
             Console.WriteLine($"winter Season");
             
            }
            else if(month=="March" || month=="May" ||month=="April")
            {
              Console.WriteLine($"Spring Season");
              
            }
            else if(month=="June" ||month=="Augest" || month=="July")
            {
            Console.WriteLine($"Summer Season");
            
            }
            else if(month=="September" || month=="October" || month=="November")
            {
              Console.WriteLine($"Rainfall Season");
              
            }
            else
            {
                Console.WriteLine($"Data invalid month entry");
                
            }
            
        }
    }
}