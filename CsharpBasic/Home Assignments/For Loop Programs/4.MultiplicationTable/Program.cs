using System;
namespace MutiplicationTable 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Table to  be calculated");
            int Table=int.Parse(Console.ReadLine());
            Console.WriteLine($"Table Limit");
            int limit=Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=limit; i++)
            {
                Console.WriteLine($"{Table} x {i}  =  {Table*i}");
                
            }
            
            
        }
    }
}