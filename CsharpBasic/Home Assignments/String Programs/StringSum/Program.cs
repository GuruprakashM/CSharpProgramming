using System;
using System.Linq;
namespace StringSum
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the string");
            string input=Console.ReadLine();
            int sum=0;
            foreach(Char output in input)
            {
                if(((int)output>=48 && (int)output<=57))
                {
                    sum+=(int)Char.GetNumericValue(output);
                }
            }
            Console.WriteLine($" The Sum of Numerics are {sum}");
            
        }
    }
}