using System;
namespace PasswordCheck
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter your password");
            string password=Console.ReadLine();
            string originalPassword="HiTeam";
            if(password==originalPassword)
            {
                Console.WriteLine($"Password is Correct");
                
            }
            else
            {
                Console.WriteLine($"your password is wrong");
                
            }
            
        }
    }
}
