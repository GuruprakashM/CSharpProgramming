using System;
namespace SumAvgByFor
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int i;
            double average,sum=0f;
            for(i=1; i<=10; i++)
            {
                sum+=i;
            }  
            Console.WriteLine($"Sum is : {sum}");
            average=sum/(i-1);
            Console.WriteLine($"Average is :  {average}");
            
        }
    }
}
