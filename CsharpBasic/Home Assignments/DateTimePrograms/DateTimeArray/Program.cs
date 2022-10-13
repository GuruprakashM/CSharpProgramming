using System;
namespace DateTimeArray
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the limit");
            int limit=int.Parse(Console.ReadLine());
            DateTime[] date =new DateTime[limit];
            for(int i=0; i<limit; i++)
            {
                Console.WriteLine($"Enter the date{i}");
                
                date[i]=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
            }
            foreach(DateTime output in date)
            {

                Console.WriteLine($"{output.ToString("dd/MM//yyyy hh:mm:ss tt")}");
                
            }
            for(int i=0; i<limit; i++)
            {
                Console.WriteLine($"Enter the date{i}");
                
                date[i]= DateTime.Now;
            }
            foreach(DateTime output in date)
            {

                Console.WriteLine($"{output.ToString("dd/MM//yyyy hh:mm:ss tt")}");
                
            }
            Console.WriteLine($"{DateTime.Now}");
            
            
        }
    }
}
