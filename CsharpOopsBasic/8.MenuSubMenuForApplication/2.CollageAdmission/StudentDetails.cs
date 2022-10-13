using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollageAdmission
{
  public enum Gender{
    Default, Male,Female,Transgender
  }
    public class StudentDetails
    { 
        //private string _name;//Field
       // public string Name { get{return _name;} set{ _name=value;}}//property by accessing Fields
      private static int s_resigternumberTracker=3000;
      public string RegisterNumber{get;}
      public string Name { get; set; }//auto property 
      public string FatherName { get; set; }
        
      public DateTime DateOfBirth { get; set; }
      public Gender Gender { get; set; }
      public long ContactNumber { get; set; }
      public string MailId { get; set; }
      public int PhysicsMark { get; set; }
      public int MathsMark { get; set; }
      public int ChemistryMark { get; set; }
        
        
      public StudentDetails()//default constructor
        {
          
           Name="yourname";
           FatherName="your Father Name";
           MailId="Your Mail Id";
           Gender=Gender.Default;
        }
        //Parametrized Constructor
      public StudentDetails(string name, string fathername,DateTime dob,Gender gender, long contactNmuber, string mailId ,int physics,int chemistry,int maths)
        {
          s_resigternumberTracker++;
          RegisterNumber="SF"+s_resigternumberTracker++;
          Name=name;
          FatherName=name;
          DateOfBirth=dob;
          Gender=gender;
          ContactNumber=contactNmuber;
          MailId=mailId;
          PhysicsMark=physics;
          MathsMark=maths;
          ChemistryMark=chemistry;
        }
        
      public bool checkEligible (double cutoff)
        {
          double average=(double)(PhysicsMark+ChemistryMark+MathsMark)/3.0;
          if(cutoff>=average)
          {
            return true;
            
          }
          else
          {
            return false;
          }
        }


       public  void ShowDetails()
        {
            Console.WriteLine($"RegisterNUmber is: {RegisterNumber} \nName: {Name}\n FatherName{FatherName} \nDateofBirth :{DateOfBirth} \nGender :{Gender} \nContactNumber :{ContactNumber} \nMailId {MailId}" );
            
        }
        ~StudentDetails()//Destructors
        {
          
        }
        
        
        
       
        
        
        
    }
}