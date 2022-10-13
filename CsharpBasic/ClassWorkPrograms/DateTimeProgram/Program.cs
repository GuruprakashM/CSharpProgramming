using System;
namespace DateTimeProgram 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            DateTime date =new DateTime(2021,8,10,10,40,32);
            Console.WriteLine($"Year:{date.Year} \nMonth:{date.Month} \nDate:{date.Day} \nHour:{date.Hour} \nMiute:{date.Minute} \nSecond:{date.Second}");
           
            //Console.WriteLine($"{date.ToString("yyyy/MM/dd HH:mm:ss")}");
            string check=date.ToString("yyyy/MM/dd HH:mm:ss tt");
            string[] split=check.Split(new string[]{"/",":"," "},StringSplitOptions.None);
            Console.WriteLine($"Dateformat");
            
            foreach( string i in split)
            {
                Console.Write($"{i} ");
                
            }
            Console.WriteLine($" \nReverse format");
          
           for(int i=split.Length-1; i>=0; i--)
           {
            Console.Write($"{split[i]} ");
            
           }

            
        }
        
    }
}
