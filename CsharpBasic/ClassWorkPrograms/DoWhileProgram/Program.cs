using System;
namespace DoWhileProgram 
{
    class Program 
    {
        public static void Main(string[] args)
        {
         
            int number=1;
            string condition=" ";
            do
            {
               Console.WriteLine($"Enter the value");
               number=int.Parse(Console.ReadLine());

                if(number%2==0)
                {
                    Console.WriteLine($"{number} is even");
                    
                }
                else
                {
                    Console.WriteLine($"{number} is odd");
                    
                }
                Console.WriteLine($"YOU WANT CONTINUE");
                condition=Console.ReadLine().ToLower();
                
                while(condition!="yes" && condition!="no")
                {
                    Console.WriteLine($"Enter valid data yes or no");
                    condition=Console.ReadLine().ToLower();
                    
                }

            }while(condition=="yes");
            
        }
    }
}
