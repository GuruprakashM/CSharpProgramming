using System;
namespace Algephra 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter your 2 Inputs");
            int firstInput=int.Parse(Console.ReadLine());
            int secondInput=int.Parse(Console.ReadLine());
            int result=(firstInput*firstInput)+(2*firstInput*secondInput)+(secondInput*secondInput);
            Console.WriteLine("the Result is " + result);
        }
    }
}
