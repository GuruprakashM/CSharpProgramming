using System;
namespace SwitchFunction 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            
            int input1,input2,result;
            Console.WriteLine($"Enter the TWO input");
            input1=int.Parse(Console.ReadLine());
            input2=int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter your CHOICE ");
            Console.WriteLine($"ADDITION MEANS PRESS +");
            Console.WriteLine($"SUBTRACTION MEANS PRESS -");
            Console.WriteLine($"MULTIPLICATION MEANS PRESS *");
            Console.WriteLine($"DIVISION MEANS PRESS /");
            Console.WriteLine($"MODULODIVISION MEANS PRESS %");
            Char yourChoice=char.Parse(Console.ReadLine());
            switch(yourChoice)
            {
                case '+':
                {
                    result=input1+input2;
                    Console.WriteLine($"the result is {result}");
                    break;
                    
                }
                case '-':
                {
                    result=input1-input2;
                    Console.WriteLine($"the result is {result}");
                    break;
                    
                }
                case '*':
                {
                    result=input1*input2;
                    Console.WriteLine($"the result is {result}");
                    break;
                    
                }
                case '/':
                {
                    result=input1/input2;
                    Console.WriteLine($"the result is {result}");
                    break;
                    
                }
            
                case '%':
                {
                    result=input1%input2;
                    Console.WriteLine($"the result is {result}");
                    break;
                    
                }
                default:
                {
                    Console.WriteLine($"YOUR DATA IS INVALID");
                    break;
                }
            }   
        }
    }
}
