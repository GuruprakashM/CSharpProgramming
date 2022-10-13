using System;
using System.Linq;
namespace RemoveString 
{
    class Program
    {
        public static void Main(string[] args)
        {
           /*Console.WriteLine($"Enter the String");
            string input=Console.ReadLine().ToLower();
            string outPut="";
           
    
            for(int output=0; output<input.Length-1; output++)
            {
                char duplicate='\0';
                int count=0;
                for(int check=1; check<input.Length-1; check++)
                {
                    if(input[output]==input[check] && count==0 && duplicate==input[check])
                    {
                       duplicate=input[output];
                        count++;
                        Console.WriteLine($"{count}");
                        
                    }
                    
                
                }
             
                outPut+=Convert.ToString(duplicate);
                Console.WriteLine($"{outPut}");*/
                    
           string input=Console.ReadLine();
           char[] output=input.ToCharArray();
           char[] duplicte=output.Distinct().ToArray();
           foreach(char output1 in duplicte)
           {
            Console.Write($"{output1}");
            
           }
           
        }
    }
}