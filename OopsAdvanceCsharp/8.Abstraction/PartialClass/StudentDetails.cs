using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public enum Gender{Default,Male,Female,Transgender}
    public enum Department{Default,EEE,ECE,CSE,MECH}
    public partial class StudentDetails
    {
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
         //constructor 1
    }
}