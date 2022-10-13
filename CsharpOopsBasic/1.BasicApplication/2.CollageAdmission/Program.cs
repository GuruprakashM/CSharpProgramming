using System;
using System.Collections.Generic;
namespace CollageAdmission
{
    class program 
    {
       
        public static void Main(string[] args)
        {
            
           //1.produtural Code---------------------------------------------------------------------
            /*Console.WriteLine($"Enter your Name");
            string name1=Console.ReadLine();
            
            Console.WriteLine($"Enter your FatherName");
            string fatherName1=Console.ReadLine();

            Console.WriteLine($"Enter your DOB format dd/MM/yyy");
            DateTime date1=new DateTime();
            date1=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

            Console.WriteLine($"Enter your Gender");
            string gender1=Console.ReadLine();

            Console.WriteLine($"Enter your PhoneNumber");
            long phone1=long.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your MailId");
            string mailId1=Console.ReadLine();

            Console.WriteLine($"Enter your Physics Mark");
            int physics1=int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your Maths Mark");
            int maths1 =int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your Chemistry Mark");
            int chemistry1=int.Parse(Console.ReadLine());


            Console.WriteLine($"Enter your Name");
            string name2=Console.ReadLine();
            
            Console.WriteLine($"Enter your FatherName");
            string fatherName2=Console.ReadLine();

            Console.WriteLine($"Enter your DOB format dd/MM/yyy");
            DateTime date2=new DateTime();
            date2=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

            Console.WriteLine($"Enter your Gender");
            string gender2=Console.ReadLine();

            Console.WriteLine($"Enter your PhoneNumber");
            long phone2=long.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your MailId");
            string mailId2=Console.ReadLine();

            Console.WriteLine($"Enter your Physics Mark");
            int physics2=int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your Maths Mark");
            int maths2 =int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your Chemistry Mark");
            int chemistry2=int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your Name");
            string name3=Console.ReadLine();
            
            Console.WriteLine($"Enter your FatherName");
            string fatherName3=Console.ReadLine();

            Console.WriteLine($"Enter your DOB format dd/MM/yyy");
            DateTime date3=new DateTime();
            date3=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

            Console.WriteLine($"Enter your Gender");
            string gender3=Console.ReadLine();

            Console.WriteLine($"Enter your PhoneNumber");
            long phone3=long.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your MailId");
            string mailId3=Console.ReadLine();

            Console.WriteLine($"Enter your Physics Mark");
            int physics3=int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your Maths Mark");
            int maths3 =int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your Chemistry Mark");
            int chemistry3=int.Parse(Console.ReadLine());

            
            Console.WriteLine($"Your data1-------------");
            Console.WriteLine($"Name: {name1} \nFatherName: {fatherName1} \nDoB :{date1.ToShortDateString()} \ngender: {gender1} \nPhoneNUmber: {phone1} \nmailid :{mailId1} \nPhysicsMark: {physics1} \nChemistry mark :{chemistry1} \nmathsMark : {maths1}" );
            

            Console.WriteLine($"Your data2---------------");
            Console.WriteLine($"Name: {name2} \nFatherName: {fatherName2} \nDoB :{date2.ToShortDateString()} \ngender: {gender2} \nPhoneNUmber: {phone2} \nmailid :{mailId2} \nPhysicsMark: {physics2} \nChemistry mark :{chemistry2} \nmathsMark : {maths2}" );
            
            Console.WriteLine($"your data3--------------");
            Console.WriteLine($"Name: {name3} \nFatherName: {fatherName3} \nDoB :{date3.ToShortDateString()} \ngender: {gender3} \nPhoneNUmber: {phone3} \nmailid :{mailId3} \nPhysicsMark: {physics3} \nChemistry mark :{chemistry3} \nmathsMark : {maths3}" );
            */
         
        //2.class and object creation code----------------------------------------------------------
            
           /* 
            StudentDetails student1=new StudentDetails();

            Console.WriteLine($"Enter your Name");
            student1.Name=Console.ReadLine();

            Console.WriteLine($"Enter your FatherName");
            student1.FatherName=Console.ReadLine();
            
            Console.WriteLine($"Enter your DOB");
            student1.DateOfBirth=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", null);

            Console.WriteLine($"Enter your Gender");
            student1.Gender=Console.ReadLine();
            
            Console.WriteLine($"Enter your PhoneNumber");
            student1.ContactNumber=long.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your mail id");
            student1.MailId=Console.ReadLine();
            
            Console.WriteLine($"Enter your PhysicsMark");
            student1.PhysicsMark=int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your ChemistryMark");
            student1.ChemistryMark=int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your MathsMark");
            student1.MathsMark=int.Parse(Console.ReadLine());
             studentList.Add(student1);
            Console.WriteLine($"Admitted");StudentDetails student2=new StudentDetails();

            Console.WriteLine($"Enter your Name");
            student2.Name=Console.ReadLine();

            Console.WriteLine($"Enter your FatherName");
            student2.FatherName=Console.ReadLine();
            
            Console.WriteLine($"Enter your DOB");
            student2.DateOfBirth=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", null);

            Console.WriteLine($"Enter your Gender");
            student2.Gender=Console.ReadLine();
            
            Console.WriteLine($"Enter your PhoneNumber");
            student2.ContactNumber=long.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your mail id");
            student2.MailId=Console.ReadLine();
            
            Console.WriteLine($"Enter your PhysicsMark");
            student2.PhysicsMark=int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your ChemistryMark");
            student2.ChemistryMark=int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your MathsMark");
            student2.MathsMark=int.Parse(Console.ReadLine());
            
            
            
            
            
            StudentDetails student3=new StudentDetails();

            Console.WriteLine($"Enter your Name");
            student3.Name=Console.ReadLine();

            Console.WriteLine($"Enter your FatherName");
            student3.FatherName=Console.ReadLine();
            
            Console.WriteLine($"Enter your DOB");
            student3.DateOfBirth=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", null);

            Console.WriteLine($"Enter your Gender");
            student3.Gender=Console.ReadLine();
            
            Console.WriteLine($"Enter your PhoneNumber");
            student3.ContactNumber=long.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your mail id");
            student3.MailId=Console.ReadLine();
            
            Console.WriteLine($"Enter your PhysicsMark");
            student3.PhysicsMark=int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your ChemistryMark");
            student3.ChemistryMark=int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your MathsMark");
            student3.MathsMark=int.Parse(Console.ReadLine());
            
            
            
            
            //Console.WriteLine($"Student1 Details");
            //Console.WriteLine($"Name: {student1.Name} \nFatherName: {student1.FatherName} \nDoB :{student1.DateOfBirth.ToShortDateString()} \ngender: {student1.Gender} \nPhoneNUmber: {student1.ContactNumber} \nmailid :{student1.MailId} \nPhysicsMark: {student1.PhysicsMark} \nChemistry mark :{student1.ChemistryMark} \nmathsMark : {student1.MathsMark}" );
            
            
            //Console.WriteLine($"Student2 Details");
           // Console.WriteLine($"Name: {student2.Name} \nFatherName: {student2.FatherName} \nDoB :{student2.DateOfBirth.ToShortDateString()} \ngender: {student2.Gender} \nPhoneNUmber: {student2.ContactNumber} \nmailid :{student2.MailId} \nPhysicsMark: {student2.PhysicsMark} \nChemistry mark :{student2.ChemistryMark} \nmathsMark : {student2.MathsMark}" );
            
            
           // Console.WriteLine($"Student3 Details");
            //Console.WriteLine($"Name: {student3.Name} \nFatherName: {student3.FatherName} \nDoB :{student3.DateOfBirth.ToShortDateString()} \ngender: {student1.Gender} \nPhoneNUmber: {student3.ContactNumber} \nmailid :{student3.MailId} \nPhysicsMark: {student3.PhysicsMark} \nChemistry mark :{student3.ChemistryMark} \nmathsMark : {student3.MathsMark}" );

           
            //studentList.Add(student2);
           // studentList.Add(student3);*/

// 3.List type code ----------------------------------------------------------------------------------------------
          
         /*do
         {
            Console.WriteLine($"read data.........");
            
            StudentDetails student1=new StudentDetails();

            Console.WriteLine($"Enter your Name");
            student1.Name=Console.ReadLine();

            Console.WriteLine($"Enter your FatherName");
            student1.FatherName=Console.ReadLine();
            
            Console.WriteLine($"Enter your DOB");
            student1.DateOfBirth=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", null);

            Console.WriteLine($"Enter your Gender");
            student1.Gender=Console.ReadLine();
            
            Console.WriteLine($"Enter your PhoneNumber");
            student1.ContactNumber=long.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your mail id");
            student1.MailId=Console.ReadLine();
            
            Console.WriteLine($"Enter your PhysicsMark");
            student1.PhysicsMark=int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your ChemistryMark");
            student1.ChemistryMark=int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your MathsMark");
            student1.MathsMark=int.Parse(Console.ReadLine());
             studentList.Add(student1);
            Console.WriteLine($"Admitted");

            
             Console.WriteLine($"do you want enter your data");
             
             condition=Console.ReadLine();
             
            
         }while(condition=="yes");
         Console.WriteLine($"----------------------------------------");*/
              
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