using System;
namespace WhileFunction 
{
    class Program 
    {
    public static void Main(string[] args)
         {
            int i=0;
            Console.WriteLine($"Even NUMBERS");
            
            while(i<=25)
            {
                if(i%2==0)
                {
                Console.WriteLine($"{i}");
                }
                i++;
                
            }
            int validNumber;
            Console.WriteLine($"Enter the Number");
            
            bool test=int.TryParse(Console.ReadLine(),out validNumber);
            while(validNumber!=0 || test==false)
            {
                if(test== false )
                {
                Console.WriteLine($"ENTER your number");
                test=int.TryParse(Console.ReadLine(),out validNumber);
                }
                else
                {
                    Console.WriteLine($"{validNumber}");
                    break;
                }
            }
         }
    }
}