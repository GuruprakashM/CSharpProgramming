using System;
namespace OddEvenPrime 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"ENTER THE LIMIT");
            int limit=int.Parse(Console.ReadLine());
            int i=1;
            Console.WriteLine($"EVEN NUMBERS");
            while(i<=limit)//EVEN
            {

               if(i%2==0)
               {
                Console.WriteLine($"{i}");
               }
               i++;
            }
            Console.WriteLine($"ODD NUMBERS");
             int j=1;
             while(j<=limit)//ODD
            {

               if(j%2!=0)
               {
                Console.WriteLine($"{j}");
               }
               j++;
            }
            Console.WriteLine($"PRIME NUMBERS");
            
            int k=1;
       
            while(k<=limit)//PRIME
            {
                int count=0;
                for(int m=1; m<=k; m++)
                {
                    if(k%m==0)
                    {
                       count++;
                    }
                }
                if(count==2)
                {
                    Console.WriteLine($"{k}");
                    
                }
                k++;
            }

        }
    }
}
