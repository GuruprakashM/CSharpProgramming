using System;
namespace UseEntryChoice
{
    class Program 
    {
        public static void Main(string[] args)
        {
             string condition=" ";
           
            do
            {
                Console.WriteLine($"Enter the value");
                int input=int.Parse(Console.ReadLine());
                if(input%2==0)
                {
                    Console.WriteLine($"The number{ input} is even");
                    
                }
                else
                {
                    Console.WriteLine($"The number{input} is odd");
                    
                }
                Console.WriteLine($"You want to continue ");
                condition=Console.ReadLine().ToLower();
                while(condition!="yes" && condition!="no")
                {
                    Console.WriteLine($"invalid data enter yes or no");
                    condition=Console.ReadLine().ToLower();
                }
                
            }while(condition =="yes");
            
        }
    }
}