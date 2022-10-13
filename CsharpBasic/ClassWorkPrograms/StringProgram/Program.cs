using System;
namespace StringProgram 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the LONG String");
            string longString=Console.ReadLine();
            Console.WriteLine($"Enter the SMAll String");
            string smallString=Console.ReadLine();
            string[] split = longString.Split( new string[]{smallString},StringSplitOptions.RemoveEmptyEntries);
            int count=0;

            foreach(string i in split)
            {
                
                count++;
                
            }
            Console.WriteLine($"The Number of Present {smallString} in {longString} is {count}");
            
            

            
            
        }
    }
}