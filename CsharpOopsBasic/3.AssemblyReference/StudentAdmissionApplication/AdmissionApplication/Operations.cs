using System;
using System.Collections.Generic;
using AdmissionLibrary;
namespace AdmissionApplication
{
    public class Operations
    {
       
        public static void MainMenu()
        {
            
           
              
            List<StudentDetails> studentList= new List<StudentDetails>();//File
           

        string condition=" ";

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
             studentList.Add(student1);
            Console.WriteLine($"Admitted");

             
             Console.WriteLine($"do you want enter your data");
             
             condition=Console.ReadLine();
             
            
         }while(condition=="yes");
         Console.WriteLine($"----------------------------------------");
                 
           foreach (StudentDetails student in studentList)
           {
             Console.WriteLine($"Student Details");
             Console.WriteLine($"Register Number : {student.RegisterNumber} \nName: {student.Name} \nFatherName: {student.FatherName} \nDoB :{student.DateOfBirth.ToShortDateString()} \ngender: {student.Gender} \nPhoneNUmber: {student.ContactNumber} \nmailid :{student.MailId} \nPhysicsMark: {student.PhysicsMark} \nChemistry mark :{student.ChemistryMark} \nmathsMark : {student.MathsMark}" );
            System.Console.WriteLine("--------------");
            bool eligibilty= student.checkEligible(75.0);
            if(eligibilty)
            {
                    Console.WriteLine($"your eligible");
            }
            else
            {
                Console.WriteLine($"not eligible");
                
            }
        
            
            
           }  
            
        }
    }
}