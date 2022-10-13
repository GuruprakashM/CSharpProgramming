using System;
using System.Collections.Generic;
using System.Linq;


namespace EmployeePayrollment
{
    public enum WorkLocation{Default,Madura,Eymard}
    public enum Gender{Default,Male,Female,Transgender}
    public class EmployeeDetails
    {
        public string Employee_ID { get; set; }//properties
        public string EmployeeName { get; set; }
        public Gender Gender{get;set;}
        public string EmpolyeeRole { get; set; }
        public WorkLocation WorkLocation { get; set; }
        public string TeamName { get; set; }
        public DateTime DateOfJoining { get; set; }
        public int NumberOfWorkingDays { get; set; }
        public int NumberofLeave { get; set; }
        
        
        public EmployeeDetails(string employee_ID,string employeeName,Gender gender,string empolyeeRole,WorkLocation workLocation,string teamName,DateTime dateofJoining)
        {
            Employee_ID=employee_ID;
            EmployeeName=employeeName;
            Gender=gender;
            EmpolyeeRole=empolyeeRole;
            WorkLocation=workLocation;
            TeamName=teamName;
            DateOfJoining=dateofJoining;
            //NumberOfWorkingDays=numberOfWorkingDays;
           // NumberofLeave=numberofLeave;
        }       
        public void ShowDetails()
        {
            Console.WriteLine($"-----------------------");
            Console.WriteLine($"YOUR PERSONAL DETAILS");
            Console.WriteLine($"------------------------");             
            Console.WriteLine($"Empolyee Id: {Employee_ID} \nEmployeeName : {EmployeeName} \nGender :{Gender} \nEmployeeRole :{WorkLocation} \nTeamName :{TeamName} \nDateJoining: {DateOfJoining.ToShortDateString()}");
            Console.WriteLine($"-------------------------------------");
            
        }
        public void GetNumberLeave()
        {
            Console.WriteLine($"Enter NUmber of Days in month");
            NumberOfWorkingDays=int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the Number of Absent Days of Month");
            NumberofLeave=int.Parse(Console.ReadLine());

            
            
        }
        public double Calculatesalary()
        {
            if(NumberofLeave==0 && NumberofLeave==0)
            {
                Console.WriteLine($"Please Enter the Details working and Absent Days");
                GetNumberLeave();
                
            }
            double salary=(NumberOfWorkingDays-NumberofLeave)*500f;
            return salary;
            
        }
        
        
        

        
    }
}