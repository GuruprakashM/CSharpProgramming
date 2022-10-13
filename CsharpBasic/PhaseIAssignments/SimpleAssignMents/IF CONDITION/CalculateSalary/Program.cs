using System;
namespace CalculateSalary 
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the choice of month");
            Console.WriteLine($"1.January \n 2.Febraury \n 3.March\n 4.APril \n5.MAy \n6.June\n 7.July 8.Augest \n 9.Septemeber \n 10.October \n 11.November \n 12.December");
            int choice=int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the number of absent");
            int absent=int.Parse(Console.ReadLine());
            int salary=0;
            switch(choice)
            {
                case 1:
                {
                     salary=(31-absent)*500;
                     Console.WriteLine($"your salary in January  is {salary}");
                     
                    break;
                }
                case 2:
                {  
                     Console.WriteLine($"ENter the current year");
                     int year=int.Parse(Console.ReadLine());
                     if(year%4==0)
                     {
                          salary=(29-absent)*500;
                     Console.WriteLine($"your salary in Febraury is {salary}");
                     }
                     else 
                     {
                     salary=(28-absent)*500;
                     Console.WriteLine($"your salary in Febraury is {salary}");
                     }
                    break;
                }
                  case 3:
                {
                     salary=(31-absent)*500;
                     Console.WriteLine($"your salary in MArch is {salary}");
                     
                    break;
                }
                        case 4:
                {
                     salary=(30-absent)*500;
                     Console.WriteLine($"your salary in april is {salary}");
                     
                    break;
                }
                            case 5:
                {
                     salary=(31-absent)*500;
                     Console.WriteLine($"your salary in MAy is {salary}");
                     
                    break;
                }
                               case 6:
                {
                     salary=(30-absent)*500;
                     Console.WriteLine($"your salary in JUne is {salary}");
                     
                    break;
                }
                                   case 7:
                {
                     salary=(31-absent)*500;
                     Console.WriteLine($"your salary in July is {salary}");
                     
                    break;
                }
                                     case 8:
                {
                     salary=(31-absent)*500;
                     Console.WriteLine($"your salary in auguest is {salary}");
                     
                    break;
                }
                         case 9:
                {
                     salary=(30-absent)*500;
                     Console.WriteLine($"your salary in September is {salary}");
                     
                    break;
                }
                           case 10:
                {
                     salary=(31-absent)*500;
                     Console.WriteLine($"your salary in october is {salary}");
                     
                    break;
                }
                                     case 11:
                {
                     salary=(30-absent)*500;
                     Console.WriteLine($"your salary in November is {salary}");
                     
                    break;
                }
                case 12:
                {
                     salary=(31-absent)*500;
                     Console.WriteLine($"your salary in December is {salary}");
                     
                    break;
                }
                default:
                {
                    Console.WriteLine($"Invalid entry");
                    break;
                }

            }
            
            

            
            
        }
    }
}
