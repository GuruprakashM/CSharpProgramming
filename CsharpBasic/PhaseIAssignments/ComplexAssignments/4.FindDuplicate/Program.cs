using System;
using System.Linq;

namespace FindDuplicate 
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the String");
            string input=Console.ReadLine();
            char[] split=input.ToCharArray();
            char[] duplicate=split.Distinct().ToArray();
           string result="";
            foreach(char output in duplicate)
            {
                result+=output;
            }
            Console.WriteLine($"The entered string is {input}");
            
            Console.WriteLine($"The duplicate removed String is {result}");
            
        }
    }
}