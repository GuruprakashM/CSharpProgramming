using System;
namespace MatrixTranspose 
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the limit of row & column");
           int rowlimit=int.Parse(Console.ReadLine());
           int columnlimit=int.Parse(Console.ReadLine());
           int [,] array=new int[rowlimit,columnlimit];//2D Array
           int[,] temp=new int[rowlimit,columnlimit];
           for(int row=0; row<rowlimit; row++)
           {
             for(int column=0; column<columnlimit; column++)
             {
                Console.WriteLine($"The Array value of {row} {column}");
                array[row,column]=int.Parse(Console.ReadLine());
             }
           }
           Console.WriteLine($"The Matrix of {rowlimit} X {columnlimit} entried");
           
            for(int row=0; row<rowlimit; row++)
            {
                for(int column=0;column<columnlimit; column++)
                {
                    Console.Write($"{array[row,column]} ");
                    
                }
                Console.WriteLine();
                
            }
           temp[0,1]=array[1,0];
           array[1,0]=array[0,1];
           array[0,1]=temp[0,1];

           Console.WriteLine($"The Matrix of {rowlimit} X {columnlimit} Transpose");
           
            for(int row=0; row<rowlimit; row++)
            {
                for(int column=0;column<columnlimit; column++)
                {
                    Console.Write($"{array[row,column]} ");
                    
                }
                Console.WriteLine();
                
            }
        }
    }
}