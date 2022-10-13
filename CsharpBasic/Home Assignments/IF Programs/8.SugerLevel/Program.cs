using System;
namespace SugarLevel
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"enter your suger Level");
            int sugarLevel=int.Parse(Console.ReadLine());
            if(sugarLevel>=0 && sugarLevel<90)
            {
             Console.WriteLine($"your sugar level is low");
              
            }
            else if(sugarLevel>=90 && sugarLevel<130)
            {
              Console.WriteLine($"your sugar level is normal");
            }
            else if(sugarLevel>=130 && sugarLevel<140)
            {
             Console.WriteLine($"your sugar level is medium");
            }
            else if (sugarLevel>=140 && sugarLevel<=170)
            {
            Console.WriteLine($"your sugar level is High");
            }
            else
            {
             Console.WriteLine($"your sugar a patient ");
            }
            
        }
    }
}
