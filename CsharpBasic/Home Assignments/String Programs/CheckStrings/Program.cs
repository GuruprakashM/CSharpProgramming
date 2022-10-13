using System;
namespace CheckStrings 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int count1=0,count2=0;
            Console.WriteLine($"Enter the  Original String");
            string input1=Console.ReadLine();
            Console.WriteLine($"Enter the String that you want to check");
            string input2=Console.ReadLine();
            foreach(char output in input1)
            {
                count1++;
            }
            foreach(char output in input2)
            {
                count2++;
            }
            if((input1==input2) && (count1==count2 ))
            {
                Console.WriteLine($"Both strings and their lengths are same ");
                
            }
         
            else
            {
                Console.WriteLine($"Both are not same string  or more space detected");
                
            }
            
        }
    }
}