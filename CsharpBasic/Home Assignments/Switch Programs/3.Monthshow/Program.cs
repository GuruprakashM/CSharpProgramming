using System;
namespace MonthShow
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
                    Console.WriteLine($"Month Have 31Days");
                    break;
                }
                case 2:
                { 
                    Console.WriteLine($"Please enter the year");
                    {
                        int year=int.Parse(Console.ReadLine());
                        if(year%4==0)
                        {
                             Console.WriteLine($"Month Have 29Days");
                        }
                        else
                        {
                             Console.WriteLine($"Month Have 28Days");
                        }
                    }
                    break;
                }
                case 3:
                {
                    Console.WriteLine($"Month Have 31Days");
                    break;
                }
                case 4:
                {
                   Console.WriteLine($"Month Have 30Days");
                    break;
                    
                }
                case 5:
                {
                    Console.WriteLine($"Month Have 31Days");
                    break;
                    
                }
                case 6:
                {
                    Console.WriteLine($"Month Have 30Days");
                    break;
                }
                case 7:
                {
                    Console.WriteLine($"Month Have 31Days");
                    break;
                    
                }
                case 8:
                {
                     Console.WriteLine($"Month Have 31Days");
                    break;
                    
                }
                 case 9:
                {
                    Console.WriteLine($"Month Have 30Days");
                    break;
                    
                }
                  case 10:
                {
                     Console.WriteLine($"Month Have 31Days");
                    break;
                    
                }
                  case 11:
                {
                     Console.WriteLine($"Month Have 30Days");
                    break;
                    
                }
                  case 12:
                {
                     Console.WriteLine($"Month Have 31Days");
                    break;
                    
                }
            }

        }
    }
}