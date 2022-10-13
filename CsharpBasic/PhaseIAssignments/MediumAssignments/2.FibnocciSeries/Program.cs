using  System;
namespace FibnocciSeries 
{
    class Program
    {
        public static void Main(string[] args)
        {
             Console.WriteLine($"Enter the limit");
             int limit=int.Parse(Console.ReadLine());
             int firstinput=1, secondinput=-1,thirdinput=0;
             for(int output=1; output<=limit; output++)
             {
                thirdinput=firstinput+secondinput;
                secondinput=firstinput;
                firstinput=thirdinput;
                Console.WriteLine($"{firstinput}");
                
             }
             
        }
    }
}
