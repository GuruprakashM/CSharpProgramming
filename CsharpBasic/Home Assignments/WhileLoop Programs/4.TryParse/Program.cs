using System;
namespace TryParse 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the Value");
            int input;
            bool check=int.TryParse(Console.ReadLine(),out input);
            while(input>=0)
            {
                if(check==false)
                {
                    Console.WriteLine($"Invalid Data");
                    Console.WriteLine($"Enter the Value");
                    check=int.TryParse(Console.ReadLine(),out input);
                }
                else if(check==true && input>5)
                {
                    Console.WriteLine($"Value can't be morethan 5");
                    Console.WriteLine($"Enter the Value");
                    check=int.TryParse(Console.ReadLine(),out input);
                }
                else
                {
                    Console.WriteLine($"{input}");
                    break;
                    
                }
            }
            
        }
    }
}
