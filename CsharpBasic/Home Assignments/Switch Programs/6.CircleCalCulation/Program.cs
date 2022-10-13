using System;
namespace CircleCalculation
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Here is the Option\n 1.Area\n 2.Perimeter \n 3.Diameter \n 4.Exit");
            Console.WriteLine($"Enter your choice");
            int choice=int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter your radius value ");
            double radius=double.Parse(Console.ReadLine()); 
            switch(choice)
            {
                case 1:
                {   
                    Console.WriteLine($"The Area is{radius*3.14f*radius}");
                    break;
                }
                    case 2:
                {   
                    Console.WriteLine($"The Perimeter is{2*3.14f*radius}");
                    break;
                }
                case 3:
                {
                    Console.WriteLine($"The Diameter is{2*radius}");
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
