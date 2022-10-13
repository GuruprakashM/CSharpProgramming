using System;
namespace VariousLength 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int meter,centiMeter,milliMeter;
            double inch,foot,Mile;
            Console.WriteLine("enter your Meter values");
            meter=int.Parse(Console.ReadLine());
            centiMeter=meter*100;
            milliMeter=centiMeter*10;
            inch=meter*39.3;
            foot=12*meter;
            Mile=0.0006213715277778*meter;
            Console.WriteLine($"centimeter:{centiMeter} \n millimeter:{milliMeter} \n inch:{inch} \n foot{foot} \n Mile:{Mile}");
        
        }
    }
}
