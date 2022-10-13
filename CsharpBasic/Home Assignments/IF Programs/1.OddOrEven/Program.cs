using System;
namespace OddOrEven 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Enter the value");
            input=int.Parse(Console.ReadLine());   
            if(input%2==0)   
            {
                Console.WriteLine($"The {input}is EVEN NUMBER");
                
            }
            else
           {
            Console.WriteLine($"The {input} is ODD NUMBER");
            
           }
            
        }
    }
}
