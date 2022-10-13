using System;
namespace PercentageMethod 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the your Maths Mark");
            int Mark1=int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the your Physics Mark");
            int Mark2=int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the your Chemistry Mark");
            int Mark3=int.Parse(Console.ReadLine());
            Console.WriteLine($"{PercentageMethod(Mark1,Mark2,Mark3)}");
            
            double PercentageMethod(int Mark1,int Mark2, int MMark3) 
            { 
                   int sum;
                   double percentage;
                   sum=Mark1+Mark2+Mark3;
                   percentage=(sum/6f);
                   return percentage;

            }
        }
    }
}
