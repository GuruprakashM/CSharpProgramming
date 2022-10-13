using System;
namespace MatrixMultiplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] array1=new int[2,3];
            int[,] array2=new int[2,3];
            int[,] result=new int[3,3];
            for(int firstrow=0; firstrow<2; firstrow++)
            {
                for(int firstcolumn=0; firstcolumn<3; firstcolumn++)
                {
                    array1[firstrow,firstcolumn]=int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine($"The first array");
            
            for(int firstrow=0; firstrow<2; firstrow++)
            {
                for(int firstcolumn=0; firstcolumn<3; firstcolumn++)
                {
                    Console.Write($"{array1[firstrow,firstcolumn]} ");
                    
                }
                Console.WriteLine();
                
            }
            for(int firstrow=0; firstrow<2; firstrow++)
            {
                for(int firstcolumn=0; firstcolumn<3; firstcolumn++)
                {
                    array2[firstrow,firstcolumn]=int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine($"the second array is");
            
            for(int firstrow=0; firstrow<2; firstrow++)
            {
                for(int firstcolumn=0; firstcolumn<3; firstcolumn++)
                {
                    Console.Write($"{array2[firstrow,firstcolumn]} ");
                    
                }
                Console.WriteLine();
                
            }

           
            
            for(int firstrow=0; firstrow<2; firstrow++)
             {
                for(int firstcolumn=0; firstcolumn<3; firstcolumn++)
                {
                    
                    result[firstrow,firstcolumn]+=array1[firstrow,firstcolumn]*array2[firstrow,firstcolumn];
                }
            }
                
                 Console.WriteLine($"The Result");
             
            
             for(int firstrow=0; firstrow<2; firstrow++)
            {
                for(int firstcolumn=0; firstcolumn<3; firstcolumn++)
                {
                    Console.Write($"{result[firstrow,firstcolumn]} ");
                    
                }
                Console.WriteLine();
                
            }
            

            
        }
    }
}