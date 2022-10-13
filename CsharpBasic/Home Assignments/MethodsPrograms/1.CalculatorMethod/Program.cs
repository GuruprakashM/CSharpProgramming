using System;
namespace CalculatorMethod 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"enthe the 2 values");
            int input1=int.Parse(Console.ReadLine());
            int input2=int.Parse(Console.ReadLine());
            Console.WriteLine($" The result of Addition {input1} {input2} is {Addition(input1,input2)}");
            subtraction(input1,input2);
            Console.WriteLine($"The result of Multiplication is {input1} {input2} is {Multiplication(input1,input2)}");
            Division(input1,input2);
            int Addition(int input1, int input2)
            {
                int result=input1+input2;
                return result;
            }         
            void subtraction(int input1, int input2)
            {
                int result=input1-input2;
                Console.WriteLine($"the result of Subtraction {input1} {input2} is {Math.Abs(result)}");
                
            }   
            int Multiplication(int input1,  int input2)
            {
                int result =input1*input2;
                return result;
            }
            void Division(int input1, int input2)
            {
                int result=input1+input2;
                Console.WriteLine($"the resilt of Division {input1} {input2} is{result}");
                
            }
        }
    }
}