using System;

using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace AdmissionProcess
{
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("College"))
            {
                Console.WriteLine($"Creating Folder");
                Directory.CreateDirectory("College");
                
            }
            Console.WriteLine($"creating file");
            if(!File.Exists ("College/StudentDetails.csv"))
            {
                
                File.Create("College/StudentDetails.csv");
            }
            if(!File.Exists("College/DepartmentDetails.csv"))
            {
                File.Create("College/DepartmentDetails.csv");
            }
            if(!File.Exists("College/AdmissionDetails.csv"))
            {
                File.Create("College/AdmissionDetails.csv");
                
            }
            


        }
        public static void ReadFile()
        {
            string[] students=File.ReadAllLines("College/StudentDetails.csv");
            foreach(var data in students)
            {
                StudentDetails  student = new StudentDetails(data);
                Opreations.studentsList.AddElement(student);
            }

            string[] Departments=File.ReadAllLines("College/DepartmentDetails.csv");
            foreach(var data2 in Departments)
            {
                DepartmentDetails  department = new DepartmentDetails(data2);
                Opreations.DepartmentsList.AddElement(department);
            }


            string[]  AdmissionDetails = File.ReadAllLines("College/AdmissionDetails.csv");
            foreach(var data3 in AdmissionDetails)
            {
                AdmissionDetails admission = new AdmissionDetails(data3);
                Opreations.AdmissionsList.AddElement(admission);

            }
        }

        public static void WritetoFiles()
        {
            string[] studentDetails=new string[Opreations.studentsList.Count];
            for(int i=0; i<Opreations.studentsList.Count; i++)
            {
                studentDetails[i]=Opreations.studentsList[i].StudentID+","+Opreations.studentsList[i].StudentName+","+Opreations.studentsList[i].FatherName+","+Opreations.studentsList[i].DoB.ToString("dd/MM/yyyy")+","+Opreations.studentsList[i].Gender+","+Opreations.studentsList[i].PhysiceMark+","+Opreations.studentsList[i].ChemistryMark+","+Opreations.studentsList[i].MathsMark;

            }
            File.WriteAllLines("College/StudentDetails.csv",studentDetails);


            string[] departdetails=new string[Opreations.DepartmentsList.Count];
            for(int i=0; i<Opreations.DepartmentsList.Count; i++)
            {
                departdetails[i]=Opreations.DepartmentsList[i].DepartmentID+","+Opreations.DepartmentsList[i].Department+","+Opreations.DepartmentsList[i].NumberOfSeats;

            }
            File.WriteAllLines("College/DepartmentDetails.csv",departdetails);

           string[] admissiondetails = new string[Opreations.AdmissionsList.Count];
           
            for(int i=0; i<Opreations.AdmissionsList.Count; i++)
            {
              admissiondetails[i]=Opreations.AdmissionsList[i].AdmissionID+","+Opreations.AdmissionsList[i].AdmissionDate.ToString("dd/MM/yyyy")+","+Opreations.AdmissionsList[i].AdmissionStatus+","+Opreations.AdmissionsList[i].DepartmentID+","+Opreations.AdmissionsList[i].StudentID;
            }
           File.WriteAllLines("College/AdmissionDetails.csv",admissiondetails);

        }
        

    }
}