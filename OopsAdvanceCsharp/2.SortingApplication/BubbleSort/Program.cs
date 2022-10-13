using System;
namespace Bubblesort
{
    class Bubblesort
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Here is the Array");
            int[] array={2,35,4,1,45,21,23,12};
            int temp=0;
            Console.WriteLine($"Before Sorting");
            foreach (int output in array)
            {
                   Console.Write($"{output} ");
                   
            }
            Console.WriteLine();
            
            
            for(int firstoutput=0; firstoutput<array.Length-1; firstoutput++)
            {
                
                for(int secondOutput=0; secondOutput<array.Length-1-firstoutput; secondOutput++ )
                {
                       if(array[secondOutput]>array[secondOutput+1])
                       {
                              temp=array[secondOutput];
                              array[secondOutput]=array[secondOutput+1];
                             array[secondOutput+1]=temp;
                       }
                }
            }
            Console.WriteLine($"After sorting ");

            foreach(int output in array)
            {
                Console.Write($"{output} ");
                
            }
            
            
        }
    }
}