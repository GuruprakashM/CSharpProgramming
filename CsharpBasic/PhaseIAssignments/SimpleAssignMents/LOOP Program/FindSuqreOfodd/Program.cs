using System;
namespace FindSuqreOfOdd
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the start value");
            int start=int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the limit");
            int limit=int.Parse(Console.ReadLine());
        long result=0;
            for(int output=start; output<=limit; output++)
            {
                if(output%2!=0)
                {
                 result+=(output*output);
                }
            }
            Console.WriteLine($" the result is {result}");
            
        }
    }
}