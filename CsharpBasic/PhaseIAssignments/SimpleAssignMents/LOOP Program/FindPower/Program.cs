using System;
namespace FindPower
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the number x");
            int input=int.Parse(Console.ReadLine());
            Console.WriteLine($"ENtre the power y");
            int power= int.Parse(Console.ReadLine());
            int result=1;
            for (int limit=1; limit<=power; limit++)
            {
                result*=input;
                Console.WriteLine($"{result}");
                
            }
            Console.WriteLine($"the result is {result}");
            
            
        }
    }
}
