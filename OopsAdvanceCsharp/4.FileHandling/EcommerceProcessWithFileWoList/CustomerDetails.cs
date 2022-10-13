using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceProcess
{
    public class CustomerDetails
    {
        //customer Details
        private static int s_customerID=1000;
        public string CustomerID{get; set;}
        public string CustomerName { get; set; }
        
        
        public string City{get; set;}
        public long MobileNumber{get;set;}
        public double WalletBalance{get;set;}
        public string EmailID{get;set;}
        
       
        public CustomerDetails(string customerName,string city, long mobileNumber,double walletBalance,string emailID)
        
        {
                 s_customerID++;
                 CustomerID="CID"+s_customerID;
                 CustomerName=customerName;
                 City=city;
                 MobileNumber=mobileNumber;
                 WalletBalance=walletBalance;
                 EmailID=emailID;


        }

        public CustomerDetails(string pass)
        {
            string[] split= pass.Split(",");
            s_customerID=int.Parse(split[0].Remove(0,3));
            CustomerID=split[0];
            CustomerName=split[1];
            City=split[2];
            MobileNumber=long.Parse(split[3]);
            WalletBalance=Convert.ToDouble(split[4]);
            EmailID=split[5];

        }

    }
}