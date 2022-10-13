using System;
namespace MessageForSpeed
{
    class Program
    {
        public static void Main(string[] args)
        {
             Console.WriteLine($"Enter the speed");
             int speed=int.Parse(Console.ReadLine());
             if(speed<=10)
             {
                Console.WriteLine($" speed {speed} is slow");
                
             }
             else if(speed>10 && speed<=50)
             {
                     Console.WriteLine($" speed {speed} is Average");
             }
            else if(speed>50 && speed<=150)
             {
                       Console.WriteLine($" speed {speed} is fast");
             }
            else if(speed>150 && speed<=1000)
             {
                  Console.WriteLine($" speed {speed} is ultrafast");
             }
            else    
             {
                         Console.WriteLine($" speed {speed} is Extremelyfast");
             }
        }
    }
}
