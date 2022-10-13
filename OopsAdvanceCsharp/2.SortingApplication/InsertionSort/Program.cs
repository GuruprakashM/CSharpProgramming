using System;
namespace InsertionSort
{
    class program 
    {
        public static void Main(string[] args)
        { 
            int temp=0,key=0;
         
            int[] array={23,34,2,4,5,6,7,3,9,1};
            Console.WriteLine($"Array before Sorting ");
            foreach(int output in array)
            {
                Console.Write($"{output} ");
                
            }
            Console.WriteLine();


            for(int output=0; output<array.Length; output++)
            {
               key=array[output];
               int inner=output-1;
               while(inner>=0 && key <array[inner])
               {
                       temp=array[inner];
                       array[inner]=array[inner+1];
                       array[inner+1]=temp;
                       inner--;
               }
            }
        
           Console.WriteLine($"Array after sorting");
            foreach(int output in array)
            {
                Console.Write($"{output} ");
                
            }
            
        }
    }
}
        /* for(int outer=1; outer<=array.Length-1; outer++)
            {
                for(int inner=0; inner<array.Length-1; inner++)
                {
                    if(array[outer]<array[inner])
                    {
                        temp=array[outer];
                        array[outer]=array[inner];
                        array[inner]=temp;
                    }
                    
                }
            }
            */
