using System;
namespace OddEvenInArray
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the limit of Array");
            int limit=int.Parse(Console.ReadLine());
            int[] array=new int[limit];
            for(int getInput=0; getInput<limit; getInput++)
            {
                Console.WriteLine($"Enter the Array value {getInput}");
               array[getInput]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"EVEN LIST");
            
            foreach(int output in array)
            {
                if(output%2==0)
                {
                  Console.WriteLine($"{output}");
                  
                }
            }
            Console.WriteLine($"ODD LIST");
            foreach(int output in array)
            {
                if(output%2!=0)
                {
                    Console.WriteLine($"{output}");
                    
                }
            }
            
        }
    }
}
