using System;
namespace SearchSubstring
{
    class Progrm 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the string");
            string input1=Console.ReadLine();
            string[] split=input1.Split(new string[] {" "},StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Enter the substring for searching");
            string input2=Console.ReadLine();
            int count=0;
            foreach(string output in split)
            {
                if(output==input2 && count==0)
                {
                    Console.WriteLine($"The word \'{input2}\' is already exists in the \"{input1}\"string");
                    count++;
                }
            }
            
            
        }
    }
}
