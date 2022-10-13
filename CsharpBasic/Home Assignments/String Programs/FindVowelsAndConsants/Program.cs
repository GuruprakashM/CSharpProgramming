using System;
namespace FindVowelsAndConsonants
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the String");
            string input=Console.ReadLine().ToLower();
             int count1=0,count2=0;
            foreach(char output in input)
            {
                if((output=='a') ||(output=='e') ||(output=='i') ||(output=='o')||(output=='u') )
                {
                    count1++;
                }
                else
                {
                    count2++;
                }
                
            }
            Console.WriteLine($"NNumber of Vowels are {count1} \nNumber of Consonants are {count2}");
            
            
        }
    }
}
