using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollageAdmission
{
    public static class Operation
    {  
    static List<StudentDetails> studentList= new List<StudentDetails>();
    static StudentDetails CurrentStudent= null;
        
        public static void MainMenu()
        {
               string condition="yes";
        do {
            Console.WriteLine($"Select option \n1.Registeration \n2.Login \n3.Exit");
            Console.WriteLine($"Enter your option in MainMenu");
            int option=int.Parse(Console.ReadLine());
         
            
        
            switch(option)
            {
                case 1:
                {
                    Console.WriteLine($"Registration");
                    Registeration();
                    break;
                }
                case 2:
                {
                    Console.WriteLine($"Login");
                    Login();
                    //SubMenu();
                    break;
                }
                case 3:
                {
                    Console.WriteLine($"Exit");
                    condition="no";
                    break;
                     
                }
            }
            
        }while(condition=="yes") ; 
        }
        public static void Registeration()
        {
            Console.WriteLine($"read data.........");
            
            Console.WriteLine($"Enter your Name");
            string name=Console.ReadLine();
            
            Console.WriteLine($"Enter your FatherName");
            string fatherName=Console.ReadLine();
            
            Console.WriteLine($"Enter your DOB");
            DateTime dateOfBirth=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", null);

            Console.WriteLine($"Enter your Gender");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
           
        
            Console.WriteLine($"Enter your PhoneNumber");
            long contactNumber=long.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your mail id");
            string mailId=Console.ReadLine();
            
            Console.WriteLine($"Enter your PhysicsMark");
            int physicsMark=int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your ChemistryMark");
            int chemistryMark=int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your MathsMark");
            int mathsMark=int.Parse(Console.ReadLine());
            StudentDetails student1=new StudentDetails(name,fatherName,dateOfBirth,gender,contactNumber,mailId,physicsMark,chemistryMark,mathsMark);
            Console.WriteLine($"{student1.RegisterNumber}");
            studentList.Add(student1);
            Console.WriteLine($"Admitted");
          
            
             
        }
        public static void Login()
        {
           Console.WriteLine($"Enter your Register NUmber");
           string RegisterId=Console.ReadLine().ToUpper();
           foreach (StudentDetails student in studentList)
           {
            CurrentStudent=student;
            Console.WriteLine($"{student.RegisterNumber}");
            if(student.RegisterNumber==RegisterId)
            {
                Console.WriteLine($"You have been SuccessFully Logined");
                SubMenu();
            }
           }
           
        }
       public static void SubMenu()
       {
            string choice="yes";
            do
            {
                
                Console.WriteLine($"here the choices of SubMenu");
                Console.WriteLine($"1.ShowDetails \n2.CheckEligible \n3.ExitSubmenu");
                Console.WriteLine($"Enter your Option in SubMenu");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine($"show Details");
                        CurrentStudent.ShowDetails();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine($"check Eligible");
                        
                        bool eligibilty= CurrentStudent.checkEligible(75.0);
                        if(eligibilty)
                             {
                            Console.WriteLine($"your eligible");
                             }
                            else
                             {
                              Console.WriteLine($"not eligible");
                
                            }
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine($"Exit Submenu");
                        choice ="no";
                        break;
                    }
                }
                
            } while (choice=="yes");
       }
    }
}