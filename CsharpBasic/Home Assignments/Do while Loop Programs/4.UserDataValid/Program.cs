using System;
namespace UserDataValid
{
    class Program
    {
       public static void Main(string[] args)
       {
         int input;
         Console.WriteLine($"Enter the value");
         bool check=int.TryParse(Console.ReadLine() ,out input);
         do
         {
         
            if(check==false)
            {
               Console.WriteLine($"Invalid data");
                Console.WriteLine($"Enter the value");
               check=int.TryParse(Console.ReadLine() ,out input);
                
            }
            else if(check==true && input>10)
            {
                Console.WriteLine($"Value can't be more than 10");
                 Console.WriteLine($"Enter the value");
               check=int.TryParse(Console.ReadLine() ,out input);
                
            }
            else
            {
                Console.WriteLine($"{input}");
                break;
                
            }
             
         }while(input>=0);
       }
    }
}
