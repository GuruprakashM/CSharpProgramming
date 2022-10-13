using System;
namespace EnumertedType
{
    public enum Gender {Default,Male,Female,Transgender}
    class Program 
    {
        public static void Main(string[] args)
        {
            //parse
            Console.WriteLine($"Select the gender option Male,Female,Transgender");
            Gender gender1=Enum.Parse<Gender>(Console.ReadLine(),true);//"true" means that Ignore case sensitive
            Console.WriteLine($"{gender1}");
            
             //Tryparse
            Console.WriteLine($"Select the gender option Male,Female,Transgender");
            Gender gender2=Gender.Default;
            bool test=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender2);
            while(!test || !((int)gender2>0 && (int)gender2<4))

            {
                Console.WriteLine($"invalid Gender \n Enter again");
                test=Enum.TryParse<Gender>(Console.ReadLine(),true,out gender2);
                
            }
            Console.WriteLine($"{gender2}");
        }
    }
}
