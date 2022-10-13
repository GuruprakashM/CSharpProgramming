using System;
namespace SumofPositiveValue 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int sum=0,input=0;
            do
            {
                Console.WriteLine($"Enter the value");
                 input=int.Parse(Console.ReadLine());
                sum+=input;
            }while(input>=0);
            Console.WriteLine($"sum of positive numbers are :{sum}");
            
        }
    }
}
