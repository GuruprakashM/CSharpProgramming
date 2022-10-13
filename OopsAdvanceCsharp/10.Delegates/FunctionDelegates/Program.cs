using System;
namespace FuctionDelegates 
{
    class program 
    {
        static double Sum (int a, int b ) {return a+b;}
             static double Subtract(int a, int b) {return a-b;}

             static double Calculator (Func<int,int,double> Sum,int x, int y)
             {
                   return Sum(x,y);
             }
            
            
        public static void Main(string[] args)
        {
             Console.WriteLine($"Calculator {Sum(10,10)}");
             Console.WriteLine($"Calculator {Subtract(20,10)}");
             
        }
    }
}
