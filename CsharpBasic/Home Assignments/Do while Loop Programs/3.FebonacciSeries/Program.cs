using System;
namespace FebonacciSeries 
{
    class Program
    {
        public static void Main(string[] args)
        {
            int input1=1, input2=-1, input3=0;
            Console.WriteLine($"Enter the Limit");
            int limit=int.Parse(Console.ReadLine());
            int initial=0;
            do
            {
                input3=input1+input2;
                input2=input1;
                input1=input3;
                Console.WriteLine($"{input1}");
                initial++;

            }while(initial<=limit);
            
        }
    }
}
