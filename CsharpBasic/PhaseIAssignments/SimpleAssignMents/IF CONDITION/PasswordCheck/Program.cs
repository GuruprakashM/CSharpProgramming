using System;
namespace PAsswoordCheck 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the Password");
            string userPassword=Console.ReadLine();
            
            string OriginalPassword="s3cr3t!P@ssw0rd";
            if(userPassword.Equals(OriginalPassword))
            {
                Console.WriteLine($"You are Welcome");
                
            }
            else
            {
                Console.WriteLine($"Invalid Password");
                
            }
            
        }
    }
}