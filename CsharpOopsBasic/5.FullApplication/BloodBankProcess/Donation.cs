using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankProcess
{
    public enum BloodGroupUpdate {Default,A_positive,B_positive,O_positive,AB_positive}
    public class Donation
    {
        private static int s_donationID=100;
        public string DonationID;
        public string DonarID;
        public DateTime DonationDate { get; set; }
        public int Weight { get; set; }
        public int Bloodpressure { get; set; }
        public int HemoGlobinCount{ get; set; }
        
        public BloodGroupUpdate BloodGroup { get; set; }
        
        
        
        
        public Donation(string donarId,DateTime donationDate,int weight,int bloodPressure, int hemoGlobinCount, BloodGroupUpdate bloodGroup)
        {
            s_donationID++;
            DonationID="DN"+s_donationID;
            DonarID=donarId;
            DonationDate=donationDate;
            Weight=weight;
            Bloodpressure=bloodPressure;
            HemoGlobinCount=hemoGlobinCount;
            BloodGroup=bloodGroup;

        }
     
        
    }
}