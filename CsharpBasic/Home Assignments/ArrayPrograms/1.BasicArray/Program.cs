using System;
namespace BasicArray 
{
    class program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the limit");
            int limit=int.Parse(Console.ReadLine());
            int[] array=new int[limit];
            
            for(int getinput=0; getinput<limit;getinput++)
            {

                Console.WriteLine($"Enter the Array value {getinput}");
                
                array[getinput]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The ARRAY LIST");
            
            foreach(int output in array)
            {
                Console.Write($"{output} ");
                
            }
            
        }
    }
}
