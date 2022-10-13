using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionProcess
{
    public enum AdmissionStatus {Default,Admitted,Cancelled}
    public class AdmissionDetails
    {
        private static int s_admissionID=1000;
        public string AdmissionID {get; set;}
        public string StudentID{get; set;}
        public string DepartmentID { get; set; }
        public DateTime AdmissionDate { get; set; }
        public AdmissionStatus AdmissionStatus{ get; set; }
        
        
    public AdmissionDetails(string studentID, string departmentID,DateTime admissionDate,AdmissionStatus admissionStatus)
    {

       
        s_admissionID++;
        AdmissionID="AD-"+s_admissionID;
        AdmissionDate=admissionDate;
        AdmissionStatus=admissionStatus;
        DepartmentID=departmentID;
        StudentID=studentID;
        
        

    }
   
        
        
    }
}