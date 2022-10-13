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
        public DateTime DateofJoining { get; set; }
        public int NumberOfWorkingDays { get; set; }
        public int NumberofLeave { get; set; }
        
        
        public EmployeeDetails(string employee_ID,string employeeName,Gender gender,string empolyeeRole,WorkLocation workLocation,string teamName,DateTime dateofJoining, int numberOfWorkingDays, int numberofLeave)
        {
            Employee_ID=employee_ID;
            EmployeeName=employeeName;
            Gender=gender;
            EmpolyeeRole=empolyeeRole;
            WorkLocation=workLocation;
            TeamName=teamName;
            DateofJoining=dateofJoining;
            NumberOfWorkingDays=numberOfWorkingDays;
            NumberofLeave=numberofLeave;
        }       
        public double Calculatesalary()
        {
            double salary=(NumberOfWorkingDays-NumberofLeave)*500f;
            return salary;
            
        }
        
        
        

        
    }
}