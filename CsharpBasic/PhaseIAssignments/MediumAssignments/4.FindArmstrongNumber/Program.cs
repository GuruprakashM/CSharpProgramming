using System;
namespace FindArmStrongNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the starting limit");
            int Start=int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the Ending Limit");
            int end=int.Parse(Console.ReadLine());
             for(int start=Start; start<=end; start++)
             {
               int count=0;
               int temp=start;
               double Armstrong=0;
                while(start!=0)
                {
                    start=start/10;
                            
                    count++;
                }
                start=temp;
                while(start!=0)
                {
                   int save=start%10;
                   start=start/10;
                   Armstrong+=Math.Pow(save,count);
                }
                start=temp;
                if(Armstrong==temp)
                {
                    Console.WriteLine($"{temp} is Armstrong");
                    
                }
                temp=0;
            
             }
        
        }
    }
}