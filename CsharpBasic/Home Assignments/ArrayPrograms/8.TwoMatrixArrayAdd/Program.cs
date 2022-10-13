using System;
namespace TwoMatrixArrayAdd
{
    class Program 
    {
        public static void Main(string[] args)
        {
          
          Console.WriteLine($"Enter the limit of row & column");
           int rowlimit=int.Parse(Console.ReadLine());
           int columnlimit=int.Parse(Console.ReadLine());
           int [,] array0=new int[rowlimit,columnlimit];//2D Array
           int [,] array1=new int[rowlimit,columnlimit];
           int [,] sum=new int[rowlimit,columnlimit];
           Console.WriteLine($"enter the value of first array");
           
           for(int row=0; row<rowlimit; row++)
           {
             for(int column=0; column<columnlimit; column++)
             {
                Console.WriteLine($"The Array value of {row} {column}");
                array0[row,column]=int.Parse(Console.ReadLine());
             }
           }
            Console.WriteLine($"enter the value of second array");
           
           for(int row=0; row<rowlimit; row++)
           {
             for(int column=0; column<columnlimit; column++)
             {
                Console.WriteLine($"The Array value of {row} {column}");
                array1[row,column]=int.Parse(Console.ReadLine());
             }
           }
           
            
           for(int row=0; row<rowlimit; row++)
           {
             for(int column=0; column<columnlimit; column++)
             {
                sum[row,column]=array0[row,column]+array1[row,column];
             }
           }
           Console.WriteLine($"Addition of {rowlimit}X{columnlimit} array");
             
            
           for(int row=0; row<rowlimit; row++)
           {
             for(int column=0; column<columnlimit; column++)
             {
                Console.Write($"{sum[row,column]} ");
                
             }
             Console.WriteLine();
             
           }

        }
    }
}