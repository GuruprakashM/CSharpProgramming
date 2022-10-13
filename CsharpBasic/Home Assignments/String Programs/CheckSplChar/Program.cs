using System;
namespace checkSplChar 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the string");
            string input=Console.ReadLine();
            int count1=0, count2=0, count3=0;
            foreach( char output in input)
            {
            
                if(((int)output>=65 &&(int)output<=90) || ((int)output>=97 && (int)output<=122))
                {
                    
                     count1++;
                }
                else if((int)output>=48 &&(int)output<=57)
                {
                    count2++;
                }
                else
                {
                    count3++;
                }
                    
            }
            Console.WriteLine($"Number of Alphabets{count1}");
            Console.WriteLine($"Number of Digits{count2}");
            Console.WriteLine($"Number of SpecialCharactes{count3++}");
            
            
        }
    }
}