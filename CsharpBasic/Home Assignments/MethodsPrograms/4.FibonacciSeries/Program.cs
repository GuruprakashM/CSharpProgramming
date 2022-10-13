using System;
namespace FibonacciSeries 
{
    class program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"enter the limit");
            int limit=int.Parse(Console.ReadLine());
            Console.WriteLine($"The results are");
            FibonacciSeries(limit);   
            void FibonacciSeries(int limit)
            {
                int first=1,sencond=-1,third=0;
                for(int start=1; start<=limit; start++)
                {
                third=first+sencond;
                sencond=first;
                first=third;
                Console.Write($"{first} ");
                }
                
            }
        }
    }
}
