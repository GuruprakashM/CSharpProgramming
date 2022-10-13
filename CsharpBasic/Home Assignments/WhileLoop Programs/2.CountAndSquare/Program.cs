using System;
namespace CountAndSquare 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"ENTER THE LIMIT");
            int limit=int.Parse(Console.ReadLine());
            int i=1,sum=0;
            while(i<=limit)
            {
               sum+=(i*i);
               i++;
               
            }
            Console.WriteLine($"{sum}");
            

        }
    }
}
