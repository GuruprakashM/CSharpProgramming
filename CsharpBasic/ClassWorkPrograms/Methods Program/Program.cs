using System;
namespace MethodsProgram 
{
  class Program 
  {
    public static void Main(string[] args)
    {
        int input1=0,input2=0;
        string condition= " ";
        do{
        Console.WriteLine($"Menu \n1.Addition \n2.Subtraction \n3.Multiplication \n4.Division");
        Console.WriteLine($"Enter your choice");
         int choice =int.Parse(Console.ReadLine());
         Console.WriteLine($"Enter the Two Values");
         input1=int.Parse(Console.ReadLine());
         input2=int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {  
                Console.WriteLine( $"The Result of {input1} & {input2} Addition is {Addition(input1,input2)}");
                break;
            }
            case 2:
             {
                Console.WriteLine($" The Result of {input1} &{input2} Subtraction is {Subtraction(input1,input2)}");
                break;
             }
             case 3:
             {
            
                Console.WriteLine($"The Result of {input1}{input2} Multiplication is {Multiplication(input1,input2)}");
                break;
             }
              case 4:
              {
                Console.WriteLine(" The Result of" + input1 + input2 + " Division is " + Division(input1,input2));
                break;
              }
              default:
              {
                Console.WriteLine($"Invalid data");
                break;
              }
        }
         Console.WriteLine($"You want to Continue Press yes or no");
         condition=Console.ReadLine().ToLower();
         while(condition!="yes"  && condition!="no")
         {
            Console.WriteLine($"Miss spelled entry");
          Console.WriteLine($"You want to Continue Press yes or no");
          condition=Console.ReadLine().ToLower();
         }
         
         }while(condition=="yes");
        int Addition(int input1, int input2)
        {
            int result =input1+input2;
            return result;
        }
        int Subtraction(int input1,int input2)
        {
            int result=input1-input2;
            return Math.Abs(result);
        }
        int Multiplication(int input1, int input2)
        {
            int result=input1*input2;
            return result;
        }
        int Division(int input1, int input2)
        {
            int result=input1/input2;
            return result;
        }
    }
  }
}