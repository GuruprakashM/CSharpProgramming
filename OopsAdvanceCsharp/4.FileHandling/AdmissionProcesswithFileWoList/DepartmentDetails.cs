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
        
        public DepartmentDetails(string data2)
        {
            string[] values=data2.Split(",");
            s_departmentID=int.Parse(values[0].Remove(0,3));
            DepartmentID=values[0];
            Department=Enum.Parse<Department>(values[1],true);
            NumberOfSeats=int.Parse(values[2]);
            

        }
        
        
        
    }
}