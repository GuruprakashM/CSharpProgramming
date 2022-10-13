using System;
namespace FindVowel
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the character");
            char input=Convert.ToChar(Console.ReadLine());
            if(input=='a' || input =='e' || input=='i' || input=='o' || input=='u')
            {
                Console.WriteLine($"{input}  is vowel");
                
            }
            else
            {
                Console.WriteLine($"{input } is not vowel");
                
            }
            
        }
    }
}

