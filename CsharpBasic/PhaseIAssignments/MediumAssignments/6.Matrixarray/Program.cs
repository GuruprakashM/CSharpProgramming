using System;
namespace MatrixArray 
{
    class Program 
    {
        public static void Main(string[] args)
        {
         Console.WriteLine($"Enter the  row limit");
         int row=int.Parse(Console.ReadLine());
         Console.WriteLine($"Enter the Column limit");
         int column=int.Parse(Console.ReadLine());
          int[,] array1=new int[row,column];
         int[,] array2=new int[row,column];
         int[,] result=new int[row,column];
          for(int rows=0; rows<row; rows++)
          {
            for(int columns=0; columns<column; columns++)
            {
                array1[rows,columns]=int.Parse(Console.ReadLine());
            }
          }
  
          for(int rows=0; rows<row; rows++)
          {
            for(int columns=0; columns<column; columns++)
            {
                array2[rows,columns]=int.Parse(Console.ReadLine());
            }
          }

          Console.WriteLine($"The result of array is");
          
        for(int rows=0; rows<row; rows++)
          {
            for(int columns=0; columns<column; columns++)
            {
                Console.Write($"{result[rows,columns]=array1[rows,columns]+array2[rows,columns]} ");
                
            }
            Console.WriteLine();
            
          }
        }
    }
}
