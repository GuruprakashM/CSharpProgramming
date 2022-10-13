using System;
namespace AritmeticCalculation
{
    class Program 
    {

        public static void Main(string[] args)
        {
            Console.WriteLine($"Here is the Option\n 1.Addition\n 2.Subtraction \n 3.Multiplication \n 4.Division \n5.Exit");
            Console.WriteLine($"Enter your choice");
            
            int choice=int.Parse(Console.ReadLine()); 
            switch(choice)

            {
                case 1:
                {   
                    Console.WriteLine($"Enter the two values");
                    int input1=int.Parse(Console.ReadLine());
                    int input2=int.Parse(Console.ReadLine());
                    Console.WriteLine($"Addition of{input1} and {input2} is{input1+input2}");
                    break;
                }
                case 2:
                {
                    Console.WriteLine($"Enter the two values");
                    int input1=int.Parse(Console.ReadLine());
                    int input2=int.Parse(Console.ReadLine());
                    Console.WriteLine($"Subtraction of{input1} and {input2} is{input1-input2}");
                    break;
                }
                case 3:
                {
                    Console.WriteLine($"Enter the two values");
                    int input1=int.Parse(Console.ReadLine());
                    int input2=int.Parse(Console.ReadLine());
                    Console.WriteLine($"Multiplication of{input1} and {input2} is{input1*input2}");
                    break;
                }
                case 4:
                {
                    Console.WriteLine($"Enter the two values");
                    int input1=int.Parse(Console.ReadLine());
                    int input2=int.Parse(Console.ReadLine());
                    Console.WriteLine($"Division of{input1} and {input2} is{input1/input2}");
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
  
