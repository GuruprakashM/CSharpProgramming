using System;
namespace DayShow
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the value from 1 to 7");
            int input1=int.Parse(Console.ReadLine()); 
            switch(input1)

            {
                case 1:
                {
                    Console.WriteLine($"Monday");
                    break;
                }
                case 2:
                {
                    Console.WriteLine($"Tuesday");
                    break;
                }
                case 3:
                {
                    Console.WriteLine($"Wednesday");
                    break;
                }
                case 4:
                {
                    Console.WriteLine($"Thursday");
                    break;
                    
                }
                case 5:
                {
                    Console.WriteLine($"Friday");
                    break;
                    
                }
                case 6:
                {
                    Console.WriteLine($"Saturday");
                    break;
                }
                case 7:
                {
                    Console.WriteLine($"Sunday");
                    break;
                    
                }
                default:
                {
                    Console.WriteLine($"Data Invalid");
                    break;
                    
                }
            }

        }
    }
}