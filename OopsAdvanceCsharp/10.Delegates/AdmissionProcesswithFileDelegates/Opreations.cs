
using System;
using System.Linq;

namespace AdmissionProcess
{
    public delegate void EventManger();
    public static class  Opreations
    {
        //private static string _eventName;
        public static event EventManger eventlink= null;
        public static void Subscribe()
        {
            eventlink += new EventManger(Files.Create);
            eventlink += new EventManger(Files.ReadFile);
            eventlink += new EventManger(Files.WritetoFiles);
            eventlink += new EventManger(Mainmenu);
            


        }
       public static void StartEvent()
       {
         Subscribe();
         eventlink();
       }
       static StudentDetails currentUser=null;
     //read file from Files.cs
        public static List<StudentDetails> studentsList =new List<StudentDetails>();
        public static List<DepartmentDetails> DepartmentsList= new List<DepartmentDetails>();
        public static List<AdmissionDetails> AdmissionsList =new List<AdmissionDetails>();

   
       public static void Mainmenu()
       {
            
          //  ObjectCreation(); 
             
            string condition="";
             do
            {
             Console.WriteLine($"Here is the choice Mainmenu");
             Console.WriteLine($"1.Student Registration \n2.Student Login \n3.CheckDepartWise Seats Availablity \n4.Exit");
             Console.WriteLine($"Enter the choice");
             int choice=int.Parse(Console.ReadLine());
             switch(choice)
             {
                case 1:
                {
                    Registration();
                    break;
                }
                case 2:
                {
                    Login();
                    break;
                }
                case 3:
                {
                    CheckAvaliblity();
                    break;
                }
                case 4:
                {
                    condition="no";
                    Console.WriteLine($"----THANK YOU--------");
                    break;
                }
             }
            if(condition=="no"){break;}
         Console.WriteLine($" Do You want to continue");
         condition=Console.ReadLine().ToLower();
             
        }while(condition=="yes");

       }
       
       public static void Registration()
       {
         Console.WriteLine($"Enter your Name ");
         string studentName=Console.ReadLine();
         Console.WriteLine($"Enter your FatherName");
         string fatherName=Console.ReadLine();
         Console.WriteLine($"Enter your DateBirth");
         DateTime doB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
         Console.WriteLine($"Enter your Gender {Gender.Male}{Gender.Female}{Gender.Transgender}");
         Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
         Console.WriteLine($"Enter your Physicsmark");
         int physiceMark=Convert.ToInt32(Console.ReadLine());
         Console.WriteLine($"Enter your ChemistryMark");
         int chemistryMark=int.Parse(Console.ReadLine());
         Console.WriteLine($"enter the Mathsmark");
         int mathsMark=int.Parse(Console.ReadLine());
         StudentDetails student =new StudentDetails(studentName,fatherName,doB,gender,physiceMark,chemistryMark,mathsMark);
         studentsList.AddElement(student);
         Console.WriteLine($"-------------------------------------"); 
         Console.WriteLine($"you have been successfully Registered");
         Console.WriteLine($"your Student ID is :{student.StudentID}");
        Console.WriteLine($"-------------------------------------");
         
       }
       
       public static void Login()
       {
        Console.WriteLine($"Enter your Student_ID ");
        string new_ID=Console.ReadLine();
        int count=0;
        foreach(StudentDetails student in studentsList)                       
        {
            if(student.StudentID==new_ID)
            {
                Console.WriteLine($"------------------------------------------");
                Console.WriteLine($"You have been successfully logined");
                Console.WriteLine($"--------------------------------------");
                count++;
                currentUser=student;
                SubMenu();
                
            }
            
        }
        if(count==0)
            {
                Console.WriteLine($"check your id properly");
                
            }
        
       }
        
       public static void CheckAvaliblity()
       {
        Console.WriteLine($"Here is the departments 1.{Department.EEE} \n2.{Department.ECE} \n3.{Department.CSE} \n4.{Department.MECH}");
        Console.WriteLine($"Which department you want to check");
        Department departments=Enum.Parse<Department>(Console.ReadLine(),true);
        Console.WriteLine($"HERE is the DEPARTMENT ");
        
        foreach(DepartmentDetails department in DepartmentsList)
        {
            Console.WriteLine($"{department.Department}--{department.DepartmentID} \n");
            

        }
        
        Console.WriteLine($"Enter your Department code");
         string code=Console.ReadLine();
         
         foreach(DepartmentDetails department in DepartmentsList)
        {
            Console.WriteLine($"{department.DepartmentID}");
            
            if(department.DepartmentID==code)
            {
                Console.WriteLine($"in department of {code} seats avaliable {department.NumberOfSeats}");
                 break;
            }
            
           
        }
        
        
       }
       public static void SubMenu()
       {
        string condition="yes";
        do
        {
        Console.WriteLine($"Here is the choice of SubMenu");
        Console.WriteLine($"1.CheckEgliblity \n2.ShowDetails \n3.Take Admission \n4.cancel Admission \n5.AdmissionDetails \n6.Exit");
        Console.WriteLine($"Enter your choice in submenu");
        int choice=int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            {
                bool test=currentUser.CheckEgliblity(75.0);
                if(test)
                {
                    Console.WriteLine($"you are Eligible");
                    
                }
                else
                {
                    Console.WriteLine($"You are not eligible");
                    
                }
                break;
            }
            case 2:
            {
                currentUser.ShowDetails();
                break;
            }
            case 3:
            {
                TakeAdmission();
                break;
            }
            case 4:
            {
                CancelAdmission();   
                break;
            }
            case 5:
            {
               ShowAdmissionDetails();
                break;

            }
             case 6:
             {
                condition="no";
                break;
             }
        }
        }while(condition=="yes");
        
       }
       
       public static void TakeAdmission()

       {
        Console.WriteLine($"Here is the Department details & id \n pick one id for the department");
        foreach(DepartmentDetails department in DepartmentsList)
        {
            Console.WriteLine($"{department.Department}---{department.DepartmentID} \n");
            
        }
        Console.WriteLine($"Enter your Department Code");
        string code=Console.ReadLine();
        bool test=currentUser.CheckEgliblity(75.0);
            if(test)
            {
            Console.WriteLine($"you are Eligible");
           
                
            }
            else
            {
                Console.WriteLine($"you  are not eligible");
                
            }
         
        if(test==true )
        {
            Console.WriteLine($"your Admission successfully granted ");

                
            AdmissionDetails admission= new AdmissionDetails(currentUser.StudentID, code, DateTime.Now, AdmissionStatus.Admitted);
            AdmissionsList.AddElement(admission);
            Console.WriteLine($"your AdmissionId is {admission.AdmissionID}");
            
            foreach(DepartmentDetails department in DepartmentsList)
            {
                if(code==department.DepartmentID)
                {
                       department.NumberOfSeats--;
                       break;
                }
            }
            
            
        }
    
        
       }
       
        public static void CancelAdmission()
       {
           Console.WriteLine($"Enter your admission Id");
           string Admissionid=Console.ReadLine().ToLower();
           foreach(AdmissionDetails admission in AdmissionsList)
           {
               if(admission.AdmissionID==Admissionid)
               {
                         admission.AdmissionStatus=AdmissionStatus.Cancelled;
                         break;
                         
               }
                AdmissionsList.AddElement(admission);
           }
            Console.WriteLine($"Here is the Department codes");
           foreach(DepartmentDetails department in DepartmentsList)
            {
            Console.WriteLine($"{department.Department}---{department.DepartmentID} \n");
            
            }
           Console.WriteLine($"Enter your department code of you selected");
           string code =Console.ReadLine();
           foreach(DepartmentDetails department in DepartmentsList)
            {
                if(code==department.DepartmentID)
                {
                       department.NumberOfSeats++;
                       break;
                }
            }
           
           Console.WriteLine($"you Admission cancelation successfully executed");
           
           
       }
    
       public static void ShowAdmissionDetails()
    {
         foreach(AdmissionDetails admission in AdmissionsList)
         {
            Console.WriteLine($"Admission Id{admission.AdmissionID} \n Admission Date{admission.AdmissionDate} \n Admission Status{admission.AdmissionStatus}");
            
         }
         foreach(StudentDetails student in studentsList)
         {
            Console.WriteLine($"studentId{student.StudentID}");
            
         }
         foreach(AdmissionDetails admission in AdmissionsList)
         {
            Console.WriteLine($"AdmissId{admission.AdmissionID}");
            
         }
        
    }
       /* public  static void ObjectCreation()
        {
        StudentDetails student1 = new StudentDetails("guru","Murugaboopathi",new DateTime(1998,10,15),Gender.Male,198,198,198);
        studentsList.AddElement(student1);
        StudentDetails student2 = new StudentDetails("Ram","Rajender",new DateTime(1998,10,19),Gender.Male,198,198,198);
        studentsList.AddElement(student2);
        DepartmentDetails Departmenteee = new DepartmentDetails(Department.EEE,29);
        DepartmentsList.AddElement(Departmenteee);
        DepartmentDetails Departmentcse = new DepartmentDetails(Department.CSE,29);
        DepartmentsList.AddElement(Departmentcse);
        DepartmentDetails Departmentmech = new DepartmentDetails(Department.MECH,30);
        DepartmentsList.AddElement(Departmentmech);
        DepartmentDetails Departmentece = new DepartmentDetails(Department.ECE,30);
         DepartmentsList.AddElement(Departmentece);
        AdmissionDetails Admission1= new AdmissionDetails("SF3001","DID101",new DateTime(2022,09,20),AdmissionStatus.Admitted);
         AdmissionsList.AddElement(Admission1);
        AdmissionDetails Admission2= new AdmissionDetails("SF3002","DID102",new DateTime(2022,10,20),AdmissionStatus.Admitted);
        AdmissionsList.AddElement(Admission2);
        }*/
    }
}
