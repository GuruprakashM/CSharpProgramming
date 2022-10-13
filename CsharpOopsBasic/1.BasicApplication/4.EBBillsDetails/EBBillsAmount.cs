using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBBillsDetails
{
    public enum SubDistrict{Default,Rajapalayam,Virudhunagar,Srivilliputtur,Sivakasi,Sattur}
    public class EBBillsAmount
    {
        public string EB_MeterID { get; set; }
        public string UserName { get; set; }
        public long PhoneNumber{get;set;}
        public string MailID { get; set; }
        public double UnitUsed{get;set;}
        public SubDistrict SubDistrict { get; set; }
        
        public EBBillsAmount(string eB_MeterID,string username,long phoneNumber,string mailID,double unitUsed)
        {
            EB_MeterID=eB_MeterID;
            UserName=username;
            PhoneNumber=phoneNumber;
            MailID=mailID;
            UnitUsed=unitUsed;
        
        }
        public double EBBillspayment()
        {
           
            double Amount=0;
            if(UnitUsed==100)
            {
                
                Amount=0;
          
            }
            else if((UnitUsed>100) &&(UnitUsed<=200))
            {
                Amount=(UnitUsed-100)*3f;
                
            }
            else if((UnitUsed>200) && (UnitUsed<=400))
            {
                Amount=(UnitUsed-100)*5f;
               

            }
            else
            {
                Amount=(UnitUsed-100)*6f;
                
            }
            return Amount;
        }
        
        
        
        
        
        
    }
}