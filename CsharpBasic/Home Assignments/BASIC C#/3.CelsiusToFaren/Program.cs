using System;
namespace CelsiusToFaren 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            float Celsius=float.Parse(Console.ReadLine());
            float kelvin,FarenHit;
            kelvin=Celsius+273f;
            FarenHit=(Celsius*(9/5f))+32;
            Console.WriteLine($"kelvin:{kelvin} \nFarenHit:{FarenHit}");
            
        }
    }
}
