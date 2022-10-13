using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBBillsDetails
{
    public static class Operation
    {
         static List<EBBillsAmount> EBAmount= new List<EBBillsAmount>();
        static EBBillsAmount EBBills =null;
         public static void MainMenu()
         {
            string condition="yes";
            do
            {
                Console.WriteLine($"Here is the choice of MainMenu");
                Console.WriteLine($"1.Registration \n2.Login \n3.Exit");
                Console.WriteLine($"Enter the choice");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        Login();
                        break;
                    }
                    case 3:
                    {
                        condition ="no";
                        Console.WriteLine($"-----THANK YOU---------");

                        
                        break;
                    }
                }
                   

            }while(condition=="yes");
         }
         public static void Registration()
         {
            Console.WriteLine($"Enter your EB-Meter Id");
            string eB_MeterID=Console.ReadLine();
            Console.WriteLine($"Enter your Name");
            string username=Console.ReadLine();
            Console.WriteLine($"Enter your Contactnumber");
            long phoneNumber=long.Parse(Console.ReadLine());
            Console.WriteLine($"Enter your MailId");
            string mailID=Console.ReadLine();
            //Console.WriteLine($"Enter the Units you have used");
            //double unitUsed=double.Parse(Console.ReadLine());

            EBBillsAmount Amount= new EBBillsAmount(eB_MeterID,username,phoneNumber,mailID);            
            EBAmount.Add(Amount);
         }

         public static void Login()
         {
            Console.WriteLine($"Enter your MeterId");
            string MeterId=Console.ReadLine();
            Console.WriteLine($"Enter the password");
            string password=Console.ReadLine();
            
            
            
            foreach(EBBillsAmount eBBills in EBAmount)
            {
                EBBills=eBBills;
                if((eBBills.EB_MeterID==MeterId) &&(eBBills.UserName.Remove(4)==password))
                {
                 Console.WriteLine($"You have Been Successfully Logined");
                 SubMenu();
                 
                }
                else
                {
                    Console.WriteLine($"Invalid entry check the MeterId or Password");
                    
                }
            }
         }
        
         public static void SubMenu()
         {
            string condition="yes";
            do
            {
                Console.WriteLine($"Here is the choices Of SubMenu");
                Console.WriteLine($"1.Showdetails \n2.Gettheunitused \n3.CalculatetheBills \n4.Exit");
                Console.WriteLine($"Enter the choice");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                    {
                         EBBills.Showdetails();
                        break;
                    }
                    case 2:
                    {
                        EBBills.GetUnit();
                        break;
                    }
                    case 3:
                    {

                       if(EBBills.UnitUsed==100)
                       {
                        Console.WriteLine($"you need to pay nothing");
                        
                       }
                       else
                       {
                        Console.WriteLine($"you need to pay Rs.{EBBills.EBBillspayment()}");
                        
                       }
                        break;
                    }
                    case 4:
                    {
                        condition="no";
                        break;
                    }
                }
                
                
            }while(condition=="yes");
         }
    
    }
}