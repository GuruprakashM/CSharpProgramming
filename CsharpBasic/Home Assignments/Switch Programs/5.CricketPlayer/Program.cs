using System;
namespace CricketPlayer 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Here is the Option\n 1.India\n 2.Pakistan \n 3.Bangladesh \n4.Exit");
            Console.WriteLine($"Enter your choice");
            
            string choice=Console.ReadLine(); 
            switch(choice)
            {
                case "India":
                {   
                    Console.WriteLine($"your Player \n 1.Dhoni \n 2.Ashwin \n 3.Jadeja \n 4.Gambir");
                    break;
                }
                case "Pakistan":
                {
                    Console.WriteLine($"your Player \n 1.jabor \n 2.Aahammed \n 3.mohammed \n 4.raki");
                    break;
                }
                case "Bangladesh":
                {
                    Console.WriteLine($"your Player \n 1.jeeva \n 2.jeethu \n 3.Jadejarav \n 4.Gambirdev");
                    break;
                }
                default:
                {
                    break;
                }
            }
        }
    }
}
