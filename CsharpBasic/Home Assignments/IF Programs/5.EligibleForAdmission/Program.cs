using System;
namespace EligibleForAdmission
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"ENTER your PHYSICS MARK");
            int physics=int.Parse(Console.ReadLine());
            Console.WriteLine($"ENTER your CHEMISTRY MARK");
            int chemistry=int.Parse(Console.ReadLine());
            Console.WriteLine($"ENTER your MATHS MARK");
            int maths=int.Parse(Console.ReadLine());
            double percentage;
            percentage=((physics+chemistry+maths)/600f)*100f;
            Console.WriteLine($"Your percentage is {percentage}%");
            
            if(percentage>75)
            {
                Console.WriteLine($"You are Eligible for ADDMISSION");
                
            }
            
        }
    }
}
