using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication
{
    public enum Gender{Default,Male,Female,Transgender}
    public enum Department{Default,EEE,ECE,CSE}
    public class UserRegisteration
    {
        private static int s_registeraterNmuber=3000;
        public string RegisterNumber { get; set; }
        public Gender Gender { get; set; }
        public string Name { get; set; }
        public Department Department{ get; set; }
        public long MobileNumber {get; set;}
        public string MailID { get; set; }
        
        public int WalletBalance{get;set;}
        
        public UserRegisteration(string name, Gender gender,Department department, long mobileNumber,string mailID,int walletBalance)
        {
              s_registeraterNmuber++;
              RegisterNumber="SF"+s_registeraterNmuber;
              Gender=gender;
              Name=name;
              Department=department;
              MobileNumber=mobileNumber;
              MailID=mailID;
              WalletBalance=walletBalance;
            
        }
      
        
         
         
        
        
    }
}