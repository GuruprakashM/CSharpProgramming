using System;
namespace Selectionsort
{
    class program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Here is the Noraml Array");
            int[] array={11,2,7,8,3,4,9};
            foreach ( int output in array)
            {
                Console.Write($"{output} ");
                
            }
            Console.WriteLine();
            
            int temp=0;
            for(int outer=0; outer<array.Length; outer++)
            {
                
                int minvalue=array[outer];
                int minindex=outer;
                for(int inner=outer; inner<array.Length; inner++)
                {
                    if(array[inner]<minvalue)
                    {
                    minvalue=array[inner];
                    minindex=inner;
                    }
                }
                if(minvalue<array[outer])
                {
                    temp=array[outer];
                    array[outer]=array[minindex];
                    array[minindex]=temp;
                }
            }
        Console.WriteLine($"After sorting Array");
           foreach( int output in array)
           {
          
            Console.Write($"{output} ");
            
            
           }

        }
    }
}