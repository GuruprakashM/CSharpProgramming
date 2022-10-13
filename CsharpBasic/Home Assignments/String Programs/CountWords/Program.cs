using System;
namespace CountWords
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the string");
            string input=Console.ReadLine();
            string[] split=input.Split(new string[] {" "},StringSplitOptions.RemoveEmptyEntries);
            int count=0;
            foreach(string output in split)
            {
                count++;
            }
            Console.WriteLine($"The number of Words in  \" {input} \"  are {count}");
            
            
        }
    }
}
