using System;
namespace ForloopFUnction 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int sum=0;
            Console.WriteLine("the result is\n");
            for(int i=0; i<=25; i++)
            {
                
            Console.WriteLine(i);
            }
             Console.WriteLine($"Enter your intial value ");
             int initial=int.Parse(Console.ReadLine());
             Console.WriteLine($"Enter your limit");
             int limit=int.Parse(Console.ReadLine());
             for(int i=initial; i<=limit; i++)
             {
                sum +=i*i;
                
             }
             Console.WriteLine($"the result is {sum}");
        }
    }
}
