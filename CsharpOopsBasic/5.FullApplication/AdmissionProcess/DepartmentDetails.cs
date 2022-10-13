using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionProcess
{
    public enum Department{Default,EEE, MECH, CSE, ECE}
    public class DepartmentDetails
    {
        private static int s_departmentID=100;
        public string  DepartmentID{get; set;}

        public Department Department { get; set; }

        public int NumberOfSeats { get; set; }

        public DepartmentDetails(Department department, int numberOfSeats)
        {
             s_departmentID++;
             DepartmentID="DID"+s_departmentID;
             Department=department;
             NumberOfSeats=numberOfSeats;
        }
        
        
        
        
    }
}