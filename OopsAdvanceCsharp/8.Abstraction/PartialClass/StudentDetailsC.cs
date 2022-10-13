using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class StudentDetails
    {
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
    }
}