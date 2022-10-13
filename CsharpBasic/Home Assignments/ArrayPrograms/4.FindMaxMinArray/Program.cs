using System;
namespace FindMinMaxArray 
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
                Console.WriteLine($"Enter the Value of Array{getInput}");
                array[getInput]=int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine($"List of Array");
            foreach(int output in array)
            {
                Console.WriteLine($"{output}");
                
            }
            int tempforMax=array[0];
            int tempforMin=array[0];
            for(int start=0; start<limit; start++)
            {
                if(tempforMax<array[start])
                {
                  tempforMax=array[start];
                }

            }
            Console.WriteLine($"The maximum value is {tempforMax}");
            for(int start=0; start<limit; start++)
            {
                if(tempforMin>array[start])
                {
                    tempforMin=array[start];
                }
            }
            Console.WriteLine($"The minimum value is {tempforMin}");
            
            

        }
    }
}
