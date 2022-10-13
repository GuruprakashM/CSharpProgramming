using System;
namespace LargestNumber
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the 3 Values");
            int input1, input2,input3;
            input1=int.Parse(Console.ReadLine());
            input2=int.Parse(Console.ReadLine());
            input3=int.Parse(Console.ReadLine());
            Console.WriteLine($"your Datas are: \n{input1} \n{input2} \n{input3}");
            if((input1> input2) && (input1>input3) )
            {
                Console.WriteLine($"The First Value is Big: {input1}");
                
            }
            else if((input2>input1) && (input2>input3))
            {
                Console.WriteLine($"The Second Value is Big: {input2}");
                
            }
            else
            {
              Console.WriteLine($"The Third Value is Big: {input3}");
              
            }
            
            
        }
    }
}
