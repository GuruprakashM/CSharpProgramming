using System;
namespace OperatorOverLoading
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Box  box1= new Box(2.0,3.4,4.5);
            Box  box2= new Box(2.3,4.5,5.6);
            Box  box3;

            double volume=0.0;
            volume=box1.CalcualteVolume();
            Console.WriteLine($"Volume 1{volume}");

            volume=box2.CalcualteVolume();
            Console.WriteLine($"Volume 2{volume}");
            box3 =box1+box2;
            volume=box3.CalcualteVolume();
            Console.WriteLine($" volume {volume}");
        
            

            //box3 = box1+ box2;
            
        }
        
    }
}