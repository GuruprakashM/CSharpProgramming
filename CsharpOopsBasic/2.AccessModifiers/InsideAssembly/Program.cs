using System;
namespace InsideAssembly;
class Program 
{
    public static void Main(string[] args)
    {
        First first = new First();
        Second second=new Second();
        Console.WriteLine($"{first.publicNumber}");
        Console.WriteLine($"{first.SecondNum}");
        Console.WriteLine($"{first.ThirdNUm}");
        Console.WriteLine($"{second.protectedvalue}");
        Console.WriteLine($"{first.showprotected}");
        
    }
}