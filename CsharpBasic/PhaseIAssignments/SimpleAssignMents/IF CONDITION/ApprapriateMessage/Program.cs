using System;
namespace ApprapriateMessage 
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the value");
           int value=int.Parse(Console.ReadLine());
           if(value<100)
           {
             Console.WriteLine($"{value } is Less than 100");
             
           }
           else if(value>=100 && value<=200)
           {
               Console.WriteLine($"{value } is in between 100 to 200");
           }
            else
            {
                   
               Console.WriteLine($"{value } is above 200");
            }
        }
    }
}