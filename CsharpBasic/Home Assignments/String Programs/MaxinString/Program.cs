using System;
using System.Linq;
using System.Collections;
namespace MaxinString
{
    class Program 
    {
    public static void Main(string[] args)
    {
        Console.WriteLine($"Enter the string");
        string input=Console.ReadLine();
  
        Char[] chArray=input.ToCharArray();
        int temp=(int)chArray[0];
        for(int output=1; output<chArray.Length; output++)
        {
             if((chArray[output]>temp) && (chArray[output]>=48 && chArray[output]<=57))
             {
                temp=chArray[output];
                
             }
             
             
          
        }

        Console.WriteLine($"The highest value of Given String is {(char)temp}");
        
    }
    }
}
