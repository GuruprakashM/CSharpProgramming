using System;
namespace FindNumInString
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the String");
            string input=Console.ReadLine();
            char[] get=input.ToCharArray();
            string Number="";
            int result=0;
            for(int i=0; i<=get.Length-1; i++)
            {
             
              Console.WriteLine($"{(int)get[i]}");
              
                
                    if((int)get[i]>=48 && (int)get[i]<=57)
                    {
                         int getvalue=(int)Char.GetNumericValue(get[i]);
                         Number+=Convert.ToString(getvalue);
                         
                     }
            }
            result=int.Parse(Number);
            if(result%2==0)
            {
                Console.WriteLine($"{result}  is EVEN");
                
            }
        }
    }
}
