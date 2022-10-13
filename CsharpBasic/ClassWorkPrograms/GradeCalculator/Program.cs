using System;
namespace GradeCalculator 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your Mark");
            int mark=int.Parse(Console.ReadLine());
            if(mark>80)
            {
                Console.WriteLine($"Your Grade is A");
                
            }
            else if(mark>60 && mark<=80)
            {
                Console.WriteLine($"Your Grade is B");
                
            }
            else if(mark>35 && mark<=60)
            {
                Console.WriteLine($"Your Grade is C");
                
            }
            else if(mark>= 0 && mark<=35)
            {
                Console.WriteLine($"Your Grade is D");
                
            }
            else
            {
                Console.WriteLine($"Your DATA is INVAILD");
                
            }
        
        }
    }
}
