using System;
namespace CyclinderVolume 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your radius AND Height");
            double radius=Convert.ToInt32(Console.ReadLine());
            double height=Convert.ToInt32(Console.ReadLine());
            double volume;
            volume=3.14*(Math.Pow(radius,2))*height;
            Console.WriteLine(volume);
        }
    }
}
