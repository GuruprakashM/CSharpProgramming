using System;
namespace MessageForTheDay
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the Temperature");
            int temperature= int.Parse(Console.ReadLine());
            if(temperature<0 )
            {
              Console.WriteLine($"FREEZING WHEATHER");
              
            }
            else if(temperature>=0 && temperature<=10)
            {
              Console.WriteLine($"VERY COLD WHEATHER");
            }
            else if(temperature>10 && temperature<=20)
            {
               Console.WriteLine($"COLD WHEATHER");
            }
            else if(temperature>20 && temperature<=30)
            {
             Console.WriteLine($"NORMAL IN TEMPERATURE");
            }
            else if(temperature>30 && temperature<=40)
            {
              Console.WriteLine($"HOT WHEATHER");
            }
            else
            {
              Console.WriteLine($"VERY HOT WHEATHER");
            }
            
        }
    }
}
