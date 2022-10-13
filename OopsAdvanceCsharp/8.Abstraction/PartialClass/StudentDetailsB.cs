using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class StudentDetails
    {
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
    }
}