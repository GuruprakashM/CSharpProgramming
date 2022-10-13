using System;
namespace CheckUserNamePassword
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the Name");
            string Name=Console.ReadLine().ToLower();
          Console.WriteLine($"Enter your Dateof Birth format \' 01012020 \'");
            string dateOfBirth=Console.ReadLine();
            string userName=Name.Substring(0,4);
            string passWord=dateOfBirth.Substring(0,4);
            Console.WriteLine($"Enter your UserName");
            string username=Console.ReadLine().ToLower();
            Console.WriteLine($"Enter the password");
            string password=Console.ReadLine();
            if(userName==username && passWord==password)
            {
                Console.WriteLine($"Password is successfully entered");
                
            }
            else
            {
            Console.WriteLine($"Incorrect username or password entered");
                
            }
            
            
            
            
        }
    }
}