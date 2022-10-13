using System;
namespace GradeCheck 
{
    class Program 
    {
      

        public static void Main(string[] args)
        {
            Console.WriteLine($"please Press key Given below for get to know about your Grade\n1.E\n2.V\n3.G\n4.A\n5.F ");
            char descriptive=char.Parse(Console.ReadLine());
            char descriptive1=char.ToUpper(descriptive);
            Console.WriteLine(descriptive1);
            
            switch(descriptive1)
            {
                case'E':
                {
                    Console.WriteLine($"Your Grade is Excellent");
                    break;
                }
                case'V':
                {
                    Console.WriteLine($"Your Grade is VeryGood");
                    break;
                }
                case'G':
                {
                    Console.WriteLine($"Your Grade is Good");
                    break;
                }
                case'A':
                {
                    Console.WriteLine($"Your Grade is Average");
                    break;
                }
                case'F':
                {
                    Console.WriteLine($"need to put great Effort");
                    break;
                }
                default:
                {
                    Console.WriteLine($"Invalid Data");
                    break;
                    
                }
            }

        }
    }
}