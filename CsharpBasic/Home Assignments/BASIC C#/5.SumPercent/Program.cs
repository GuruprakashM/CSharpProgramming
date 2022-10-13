using System;
namespace SumPercent 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int maths,physics,chemistry,sum;
            double percentage;
            Console.WriteLine("enter the your Maths Mark");
            maths=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the your Physic Mark");
            physics=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the your Chemistry Mark");
            chemistry=int.Parse(Console.ReadLine());
            sum=(physics+maths+chemistry);
            percentage = ((sum / 300f) * 100f);
            Console.WriteLine("the TOTAL is\n"+sum +"\n"+percentage+"%");
       


        }
    }
}
