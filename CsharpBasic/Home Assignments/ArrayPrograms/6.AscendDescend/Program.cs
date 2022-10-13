using System;
namespace AscendDescend 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the Limit of Array");
            int limit=int.Parse(Console.ReadLine());
            int[] array=new int[limit];
            for(int getInput=0; getInput<limit; getInput++)
            {
                Console.WriteLine($"Enter the Array value {getInput}");
                
                array[getInput]=int.Parse(Console.ReadLine());
            }
            int temp=0;
             for(int output=0; output<limit; output++)
             {
                for(int check=output+1; check<limit; check++)
                {
                    if(array[output]>array[check])
                    {
                        temp=array[check];
                        array[check]=array[output];
                        array[output]=temp;
                    }
                }
             }
             Console.WriteLine($"the ascend{temp}");
             foreach(int output in array)
             {
                Console.WriteLine($"{output}");
                
             }
             int temp1=0;
             for(int output=0; output<limit; output++)
             {
                for(int check=output+1; check<limit; check++)
                {
                    if(array[output]<array[check])
                    {
                        temp1=array[output];
                        array[output]=array[check];
                        array[check]=temp1;
                    }
                }
             }
            Console.WriteLine($"The Descend");
            foreach(int output in array)
            {
                Console.WriteLine($"{output}");
                
            }
            
            
        }
    }
}