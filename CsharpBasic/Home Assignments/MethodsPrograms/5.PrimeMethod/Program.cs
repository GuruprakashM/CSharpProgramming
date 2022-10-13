using System;
namespace PrimeMethod 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the data ");
            int data=int.Parse(Console.ReadLine());
            Console.WriteLine($"{PrimeMethod()}");
            
            string PrimeMethod()
            {
                 int count =0;
                 string Message= " ";
                for(int start=1; start<=data; start++)
                {
                   
                    if(data%start==0)
                    {
                      count++;
                    }

                }
                if(count==2)
                {
                    Message=$"The Given Number {data} is Prime";
                    
                }
                else
                {
                   Message=$"The Given Number {data} is Not Prime";
                   
                }
                return Message;

            }
            
        }
    }
}