using System;
using System.Linq;
using System.Collections.Generic;
using EBillPaymentLibrary;
namespace EBillPaymentApplication
{
    class Operations
    {
     
        public static void Mainmenu()
        {
            List<EBBillsAmount> EBAmount= new List<EBBillsAmount>();
            string check="";
            do
            {
            Console.WriteLine($"Enter your EB-Meter Id");
            string eB_MeterID=Console.ReadLine();
            Console.WriteLine($"Enter your Name");
            string username=Console.ReadLine();
            Console.WriteLine($"Enter your Contactnumber");
            long phoneNumber=long.Parse(Console.ReadLine());
            Console.WriteLine($"Enter your MailId");
            string mailID=Console.ReadLine();
            Console.WriteLine($"Enter the Units you have used");
            double unitUsed=double.Parse(Console.ReadLine());

            EBBillsAmount Amount= new EBBillsAmount(eB_MeterID,username,phoneNumber,mailID,unitUsed);            
            EBAmount.Add(Amount);
            Console.WriteLine($"Do you want to continue ");
             check=Console.ReadLine().ToLower();
            
            }while(check=="yes");
            foreach(EBBillsAmount amount in EBAmount)
            {
            Console.WriteLine($"------------------------------------------");
            Console.WriteLine($"PayMent Details of {amount.EB_MeterID}");
            Console.WriteLine($"-------------------------------------------");
            Console.WriteLine($"EBmeterId: {amount.EB_MeterID} \nUsername: {amount.UserName} \nPhoneNumber :{amount.PhoneNumber} \nMailid :{amount.MailID} \nUnitUsed :{amount.UnitUsed}");
            Console.WriteLine($"---------------------------------------------");
            if((int)amount.EBBillspayment()==0)
            {
                Console.WriteLine($"You no need to pay anything you are under free cost benefits");
            }
            else
            {
                Console.WriteLine($"You need to pay Rs.{amount.EBBillspayment()}");
                
            }
            Console.WriteLine($"---------------------------------------------");
            
            }
            
        }
    }
}
