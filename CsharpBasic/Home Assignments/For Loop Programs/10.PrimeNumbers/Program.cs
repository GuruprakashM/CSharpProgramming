using System;
namespace PrimeNumbers
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int limit=0;
            Console.WriteLine($"Enter the Limit");
            limit=int.Parse(Console.ReadLine());
            while(limit>0)
            {
            if(limit==1)
            {

                Console.WriteLine($"{limit} is prime as well composite number ");
                

            }
            break;
            }
            if(limit>1)
            {
            Console.WriteLine($"PRIME LIST");
            
            for(int i=2; i<=limit; i++ )
            {
                int count =0;
                for(int j=1; j<=limit; j++)
                {
                     if(i%j==0)
                     {
                        count++;
                     }
                }
                if(count==2)
                {
                    Console.WriteLine($"{i} ");
                    
                }
               
            }
            }
            
        }
    }
}
