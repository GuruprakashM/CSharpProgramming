using System;
namespace PalindromeInNum
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the value");
            int input=int.Parse(Console.ReadLine());
            string palindrome=Convert.ToString(input);
            string get="";
            char[] output=palindrome.ToCharArray();
            
            for(int check=output.Length-1; check>=0; check--)
            {
                get+=output[check];
                
                
            }
             
            if(palindrome.Equals(get))
            {
                Console.WriteLine($"{input} is Palindrome");
                
            }
            else
            {
              Console.WriteLine($"{input} is Not Palindrome");
              
            }
        }
    }
}