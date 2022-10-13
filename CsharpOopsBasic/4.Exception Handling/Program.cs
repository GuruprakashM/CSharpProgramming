using System;
namespace ExceptionHandling
{
    class Program 
    {
        public static void Main(string[] args)
        {
          

            try{
             Console.WriteLine($"Enter the input1");
            int input1=int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the input2");
            int input2=int.Parse(Console.ReadLine());
            int output=input1/input2;
           

            }
            catch( DivideByZeroException e)//Specified
            {
                Console.WriteLine($"{e.Message}");
                Console.WriteLine($"{e.StackTrace}");
                
                
            }
            catch(Exception e)//General
            {
                Console.WriteLine($"{e.Message}");
                
            }
          
            finally
            {
                Console.WriteLine($"Output Exceuded");
                
            }

                        
        }
    }
}