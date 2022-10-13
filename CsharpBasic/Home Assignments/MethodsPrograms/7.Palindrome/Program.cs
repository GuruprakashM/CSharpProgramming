using System;
namespace Palindrome
{

    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"{Palindrome()}");
            
            string Palindrome()
            {
                Console.WriteLine($"ENTER THE STRING ");
                string palindrome=Console.ReadLine();
                
                string  check ="", message="";
                for(int start=palindrome.Length-1; start>=0; start--)
                {
                       check+=palindrome[start];
                }
                
                if(palindrome==check)
                {
                    message=$" The given String {palindrome} is Palindrome";
                    
                }
                else
                {
                    message=$"The given String {palindrome} is not Palindrome";
                }
                return message;
            }
            
        }
    }
}
