using System;
using System.Linq;
namespace Anagram 
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the first string");
            string first=Console.ReadLine();
            Console.WriteLine($"Enter the second string");
            string second=Console.ReadLine();
            string result=first+second;
            char[] resultsplit=result.ToCharArray();
            char[] duplicate=resultsplit.Distinct().ToArray();
              string result1="";

            foreach(char input in duplicate)
            {
                result1+=input;
             
                
            }
         Console.WriteLine($"{result1}");
         if(result1.Length<=first.Length)
         {
            Console.WriteLine($"{first} and {second} is Anagram");
            
         }
         else
         {
            Console.WriteLine($"{first} and {second}  is not Anagram");
            
         }
            
        }
    }
}