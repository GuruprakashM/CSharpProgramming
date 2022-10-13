using System;
namespace VoteELigible 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"ENTER your AGE");
            int age=int.Parse(Console.ReadLine());
            if(age!=0 && age>=18)
            {
                Console.WriteLine($"Congratulation you are Eligible for Vote");
                
            }
            else if(age>0 && age<18)
            {
             Console.WriteLine($"You are Not Eligible");
             
            }
            else
            {
                Console.WriteLine($" InVAILD DATA");
                
            }
        }
    }
}
