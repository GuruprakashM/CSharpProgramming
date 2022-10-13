using System;
namespace TailorSeries
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the limit");
            int limit=int.Parse(Console.ReadLine());
            double finalResultofTailor=0;
            for(int output=0; output<=limit; output++)
            {
                
                    int factorial=1;
                    for(int fact=output; fact>0; fact--)
                    {
                        factorial*=fact;
                        Console.WriteLine($"{factorial}");
                        
                    }
                    finalResultofTailor+=(Math.Pow(2f,output)/factorial);
                 
                
            }
           
            Console.WriteLine($"{finalResultofTailor}");
            
        }
    }
}