using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListFileManuplation
{
    public enum Gender{Default,Male,Female};
    public  class StudentDetails
    {
         public string Name{ get; set; }
         public string FatherName { get; set; }
         public  Gender Gender{ get; set; }
         public DateTime BirthDate{ get; set; }
    }
}