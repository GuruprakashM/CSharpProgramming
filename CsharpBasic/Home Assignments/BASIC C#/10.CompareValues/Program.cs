using System;
namespace CompareValues
{
    class Programc
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter two values");
            int input1,input2;
            input1=int.Parse(Console.ReadLine());
            input2=int.Parse(Console.ReadLine());
            bool compare;
            Console.WriteLine($"{compare=(input1>input2)}");
            Console.WriteLine($"{compare=(input1<input2)}");
            Console.WriteLine($"{compare=(input1>=input2)}");
            Console.WriteLine($"{compare=(input1==input2)}");
            Console.WriteLine($"{compare=(input1!=input2)}");
            Console.WriteLine($"{compare=(input1<=input2)}");
            Console.WriteLine($"{compare=(input1>10) && (input2>=10)}");
            Console.WriteLine($"{compare=(input1>=10) && (input2>=30)}");
            Console.WriteLine($"{compare=!(input1>20)}");
            string check=(input1==15)?"true":"false";
            Console.WriteLine(check);
            Console.WriteLine(input1++);
            Console.WriteLine(input1--);
            
            
                       
        }
    }
}