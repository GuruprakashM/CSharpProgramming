using System;
namespace SumOfArray
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int sum=0;
            Console.WriteLine($"Enter the limit of Array");
            int limit=Convert.ToInt32(Console.ReadLine());
            int[] array=new int[limit];
            for(int getInput=0; getInput<limit; getInput++)
            {
            Console.WriteLine($"Enter the Array Value of {getInput}");
            array[getInput]=int.Parse(Console.ReadLine());
                
            }
            foreach(int output in array)
            {
              sum+=output;
                
            }
            Console.WriteLine($"Sum of Array is {sum}");
            
            
        }
    }
}
