using  System;
namespace CircleAraPerimeter
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the Radius");
            
            double radius=double.Parse(Console.ReadLine());
        
            Console.WriteLine($"{radius}");            
            double area=3.14f*radius*radius;
            double periMeter=2*3.14f*radius;
            Console.WriteLine($"The Area  is : {area} \nthe Perimeter is: {periMeter}");

            
            
        }
    }
}
