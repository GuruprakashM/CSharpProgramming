using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankProcess
{

   public enum BloodGroup {Default,A_positive,B_positive,O_positive,AB_positive}
    public class UserRegistration
    {
      private static int s_donarId=1000;
      public string DonarID { get; set; }
      public string DonarName { get; set; }
      public long PhoneNumber { get; set; }
      
      public BloodGroup BloodGroup { get; set; }

      public int Age { get; set; }
      
      public DateTime LastDonationDate { get; set; }
      
      
      public UserRegistration(string donarName,long phoneNumber, BloodGroup bloodGroup, int age,DateTime lastDonationdate)

      {
        s_donarId++;
        DonarID="DNR"+s_donarId;
        DonarName=donarName;
        PhoneNumber=phoneNumber;
        BloodGroup=bloodGroup;
        Age=age;
        LastDonationDate=lastDonationdate;

      }

       public string NextEligibleDate()
        {
            DateTime date =new DateTime();
              date=LastDonationDate;
              date=date.AddDays(60);
              return date.ToShortDateString();       
            
        }

        
      
      
      
        
        
    }
}