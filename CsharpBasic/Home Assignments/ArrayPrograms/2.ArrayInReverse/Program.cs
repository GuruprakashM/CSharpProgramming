using System;
namespace ArrayInReverse
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the Array Limit");
            int limit=int.Parse(Console.ReadLine());
            int[] array=new int[limit];
            for(int getInput=0; getInput<=limit-1; getInput++)
            {
              Console.WriteLine($"Enter Array Value {getInput}");
              array[getInput]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Normal Array list");
            foreach( int output in array)
            {
            
              Console.WriteLine($"{output}");
             
             
            }
            Console.WriteLine($"The Reverse Array list");
            for(int start=limit-1; start>=0; start--)
            {
              
                Console.WriteLine($"{array[start]}");
                
                
            }
            
        }
    }
}
