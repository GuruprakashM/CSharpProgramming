using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayrollment
{
    public static class Operation
    {
        static List<EmployeeDetails> employeelist= new List<EmployeeDetails>();
        static EmployeeDetails Employees =null;
        public static void MainManu()
        {
            string condition="yes";
            do
             {

                Console.WriteLine($"Here is the choice of MainMenu");
                Console.WriteLine($"1.Registersion \n2.Login \n3.Exit");
                Console.WriteLine($"Enter your choice");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        Registeration();
                        break;
                    }
                    case 2:
                    {
                        Login();
                        break;

                    }
                    case 3:
                    {
                        Console.WriteLine($"----------THANK YOU------");
                        condition="no";
                        break;
                    }

                }

            
            } while (condition=="yes");
        }
        public static void Registeration()
         {
            
        Console.WriteLine($"Enter your Employee_Id");
        string employee_ID=Console.ReadLine();
      
        
        Console.WriteLine($"Enter your Name");
        string employeeName=Console.ReadLine();

        Console.WriteLine($"Enter your Gender");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);

        Console.WriteLine($"Enter your Role");
        string empolyeeRole=Console.ReadLine();
        
        Console.WriteLine($"Enter Your WorkLocation");
        WorkLocation workLocation=Enum.Parse<WorkLocation>(Console.ReadLine(),true);
        
        Console.WriteLine($"Enter your Team Name");
        string teamName=Console.ReadLine();
        
        Console.WriteLine($"Enter your Date Of joining");
        DateTime dateofJoining=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        
        /*Console.WriteLine($"Enter your Number Of Working Days");
        int numberOfWorkingDays=int.Parse(Console.ReadLine());

        Console.WriteLine($"Enter your Number Of Absent Days");
        int numberofLeave=int.Parse(Console.ReadLine());*/
        EmployeeDetails Employee= new EmployeeDetails(employee_ID,employeeName,gender,empolyeeRole,workLocation,teamName,dateofJoining);
        
        employeelist.Add(Employee);
         }

        public static void Login()
        {
            Console.WriteLine($"Enter your EmpolyeeId");
            string employee_id=Console.ReadLine();
            Console.WriteLine($"Enter the Password");
            string password=Console.ReadLine();
            foreach(EmployeeDetails  employee in employeelist)
            {
                Employees=employee;
                if((employee.Employee_ID==employee_id) &&(password==employee.EmployeeName.Remove(4)))
                {
                   Console.WriteLine($"you have been successfully logined");
                   SubMenu();
                   
                }
                else
                {
                    Console.WriteLine($"Invaild Entry Employee_Id or Password incorrect");
                    
                }
            }
            
            
        }
        public static void SubMenu()
        {
            string condition="yes";
            do
            {
                Console.WriteLine($"Here is the choice of SubMenu");
                Console.WriteLine($"1.ShowDetails \n2.GetNumberLeave \n3.Calculate the Salary \n4.Exit");
                Console.WriteLine($"Enter your choice");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        Employees.ShowDetails();
                        break;

                    }
                    case 2:
                    {
                        Employees.GetNumberLeave();
                        break;
                    }
                    case 3:
                    {
                       Console.WriteLine($" your salary of this month Rs.{Employees.Calculatesalary()}");
                        break;
                    }
                    case 4:
                    {
                        condition="no";
                        break;
                    }
                }      
                

            }while(condition=="yes");
        }
    
    }
}