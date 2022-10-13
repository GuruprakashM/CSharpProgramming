using System;
namespace HelloName
{
    class Program 
    {
        public static void Main(string[] args)
        {
            string name="guru";
            Console.WriteLine("Hello" + name);//concatenation
            Console.WriteLine("Hello{0}",name);//Placeholder
            Console.WriteLine($"Hello{name}");//interpolation
        }
    }
}
