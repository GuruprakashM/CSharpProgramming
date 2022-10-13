using System;
using System.Linq;
using System.Collections.Generic;
using EmployeeLibrary;
namespace EmployeePayApplication
{
    class Program 
    {
    public static void Main(string[] args)
    {
         List<EmployeeDetails> employeelist= new List<EmployeeDetails>();
        String condition="";
        do
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
        
        Console.WriteLine($"Enter your Number Of Working Days");
        int numberOfWorkingDays=int.Parse(Console.ReadLine());

        Console.WriteLine($"Enter your Number Of Absent Days");
        int numberofLeave=int.Parse(Console.ReadLine());
        EmployeeDetails Employee= new EmployeeDetails(employee_ID,employeeName,gender,empolyeeRole,workLocation,teamName,dateofJoining,numberOfWorkingDays,numberofLeave);
        
        employeelist.Add(Employee);
        Console.WriteLine($"Do you want to continue for one more entry");
        condition=Console.ReadLine().ToLower();
        
        Console.WriteLine($"{Employee.EmployeeName}");
        

        }while(condition=="yes");

        foreach(EmployeeDetails employee in employeelist)
        {
          Console.WriteLine($"-----------------------------------------------------");
          Console.WriteLine($"THe DETAILS ABOUT EMPLOYEE_ID {employee.Employee_ID}");
          Console.WriteLine($"-----------------------------------------------------");
          
          Console.WriteLine($"Employee_id: {employee.Employee_ID} \nEmployeeName: {employee.EmployeeName} \nGender:{employee.Gender} \nEmployeeRole :{employee.EmpolyeeRole} \nEmployee Worklocation {employee.WorkLocation} \nTeamName: {employee.TeamName} \nDateOfJoining :{employee.DateofJoining.ToShortDateString()} \nNumberofWorking Dates:{employee.NumberOfWorkingDays} \nNumberofLeaveTaken :{employee.NumberofLeave} ");
          Console.WriteLine($"-----------------------------------------------------");
          Console.WriteLine($"Your salary is Rs.{employee.Calculatesalary()}");
          Console.WriteLine($"-----------------------------------------------------");
          
          
        }
          
    }
    }
}
