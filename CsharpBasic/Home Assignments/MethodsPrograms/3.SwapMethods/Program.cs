using System;
namespace SwapMethods 
{
    class Program 
    {
        public static void Main(string[] args)
        {
          
            swap();
            void swap()
            {
            Console.WriteLine($"Enter the Input1");
            int input1=int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the Input2");
            int input2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Entered values are \n {input1} {input2}");
            int temp=input1;
            input1=input2;
            input2=temp;
            Console.WriteLine($"Swap Numbers are {input1} {input2}");
               
            }
            
            
        }
    }
}
