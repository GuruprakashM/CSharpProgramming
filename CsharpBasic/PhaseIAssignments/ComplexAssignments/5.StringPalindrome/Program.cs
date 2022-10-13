using System;
namespace StringPalindrome 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the string");
            string original=Console.ReadLine();
            char[] check=original.ToCharArray();
            string result="";
            for(int output=check.Length-1; output>=0; output--)
            {
                 result+=check[output];
                 
            }
          
            
            if(original.Equals(result))
            {
                Console.WriteLine($"{original} is Palindrome");
                
            }
            else
            {
                Console.WriteLine($"{original} is not Palindrome");
                
            }
        }
    }
}
