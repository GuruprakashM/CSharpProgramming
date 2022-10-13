using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationProcess
{
    public enum Gender{Default,Male,Female,Transgender}
    public class Beneficiary
    {
        private static int s_registerNumber=1000;
        public string RegisterNumber {get;set;}
        public string Name { get; set; }
        public int Age{get;set;}
        
        public Gender Gender{get; set;}
        public string City{get; set;}
        public long MobileNumber{get; set;}

    
        
        public Beneficiary(string name,int age,Gender gender,string city,long mobileNumber)
        {
           s_registerNumber++;
           RegisterNumber="BID"+s_registerNumber;
           Name=name;
           Age=age;
           Gender=gender;
           City=city;
           MobileNumber=mobileNumber;

        }
        

    }
}