using System;
namespace FibonacciSeries 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int first=1, second=-1, third=0;
            int limit=int.Parse(Console.ReadLine());
            for(int i=1; i<10; i++)
            {
                third=first+second;
                second=first;
                first=third;
                Console.WriteLine($"{first}");
                
            }

        }
    }
}
