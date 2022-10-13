using System;
namespace ArmstrongNum
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int count=0;
            double split=0,sum=0;
            Console.WriteLine($"Enter the Number");
            Console.WriteLine($"{split}");
            
            int input=int.Parse(Console.ReadLine());
            int temp=input;
            while(input!=0)
            {
              
              input=input/10;
              count++;
            }
            input=temp;
            while(input!=0)
            {
                split=input%10;
                input=input/10;
                sum+=Math.Pow(split,count);
            }
            input=temp;
            if(input==sum)
            {
                Console.WriteLine($"{sum}is Armstrong");
                
            }
            else
            {
                Console.WriteLine($"{sum} is Not Armstrong");
                
            }

            

        }
    }
}