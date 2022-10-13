using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankProcess
{
    public static class Operation
    {
       static List<UserRegistration> usersList= new List<UserRegistration>();
       static List<Donation> donationList =new List<Donation>();
       static UserRegistration currentuser=null;
        public static void DefaultSetup()
        {
         UserRegistration firstuser = new UserRegistration("guru",9894999231,BloodGroup.A_positive,21, new DateTime(2022,1,12));
         usersList.Add(firstuser);
         UserRegistration secondUser =new UserRegistration("prakash",989999,BloodGroup.B_positive,21,new DateTime(2022,12,11));
         usersList.Add(secondUser);

         


         Donation firstDonate =new Donation("DNR1001",new DateTime(2022,09,09),50,98,40,BloodGroupUpdate.A_positive);
         donationList.Add(firstDonate);
         Donation secondDonate=new Donation("DNR1002",new DateTime(2022,09,07),67,98,56,BloodGroupUpdate.B_positive );
         donationList.Add(secondDonate);

        }
         public static void Mainmenu()
         {
            DefaultSetup();
            string condition="";
            do
            {
             Console.WriteLine($"Here is the options of Menu");
             Console.WriteLine($"1.UserRegisteration \n2.UserLogin \n3.FetchDonorDetails \n4.Exit");
             Console.WriteLine($"Enter your choice");
             int choice= int.Parse(Console.ReadLine());
             switch(choice)
             {
                case 1:
                {
                    Registeration();
                    break;
                }
                case 2:
                {
                    Login();
                    break;
                }
                case 3:
                {
                    FetchDonorDetails();
                    break;
                }
                case 4:
                {
                    //Exit();
                    condition="no";
                    break;
                }
             }
             Console.WriteLine($"Do you want to continue with MainMenu");
             condition=Console.ReadLine();
             
             
            }while(condition=="yes");
         }
         public static void Registeration()
         {
            Console.WriteLine($"Enter your name");
            string donarName=Console.ReadLine();

            Console.WriteLine($"Enter your Age");
            int age =int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Enter your PhoneNumber");
            long phoneNumber=long.Parse(Console.ReadLine());

            Console.WriteLine($"Enter your BloodGroup");
            BloodGroup bloodGroup=Enum.Parse<BloodGroup>(Console.ReadLine(),true);

            Console.WriteLine($"Last Donation date");
           DateTime lastDonationDate=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

            
            UserRegistration user = new UserRegistration(donarName,phoneNumber,bloodGroup,age,lastDonationDate);
            usersList.Add(user);
            Console.WriteLine($"you have been successfully Registered");
            
            Console.WriteLine($"Here is the Your DonarId{user.DonarID}");
            
         }
          
         public static void Login()
         {
            Console.WriteLine($"Enter your LoginId");
            string userid=Console.ReadLine();
            int count=0;
            foreach(UserRegistration user in usersList)
            {
                if(user.DonarID==userid)
                {
                    currentuser=user;
                    Console.WriteLine($"You have been successfully Logined");
                    count++;
                    SubMenu();
                    
                }
            }
            if(count==0)
            {
                Console.WriteLine($"invalid user id ensure with that");
                
            }
            
         }
         public static void FetchDonorDetails()
         {

            Console.WriteLine($"Enter the bloodpgroup");
            BloodGroupUpdate bloodGroup =Enum.Parse<BloodGroupUpdate>(Console.ReadLine(),true);
            string donarId="";
            foreach(Donation check in donationList)
            {

                if( bloodGroup == check.BloodGroup)
                {
                   donarId=check.DonarID;
                }

            }
            foreach(UserRegistration getDetails in usersList)
            {
                if(donarId==getDetails.DonarID)
                {
                    Console.WriteLine($"-----------------------------------------------------------------");
                    
                    Console.WriteLine($"Name: {getDetails.DonarName} \nPhoneNumber: {getDetails.PhoneNumber} \nAge :{getDetails.Age} \nBloodgroup {getDetails.BloodGroup}");
                    
                    Console.WriteLine($"---------------------------------------------------------------");
                    
                }
            }

         }
        
        public static void SubMenu()
        {
         string condition="";
        do
        {
           Console.WriteLine($"Here is the Details of subMenu");
           Console.WriteLine($"1.DonateBlood \n2.DonationHistory \n3.NextEligiblityDate \n4.Exit");
           Console.WriteLine($"Enter your choice");
           int choice=int.Parse(Console.ReadLine());
           switch(choice)
           {
            case 1:
            {
                BloodDonate();
                break;
            }
             case 2:
             {
                DonationHistory();
                break;
             }
             case 3:
             {
                Console.WriteLine($"Your Next Eligible Date is  {currentuser.NextEligibleDate()}");
                
               
                break;
             }
             case 4:
             {
                condition ="no";
                //Exit
                break;
             }
           }
           if(condition=="no"){break;}
           Console.WriteLine($"Do you continue with Sub Menu");
           condition=Console.ReadLine();
           
        } while(condition=="yes");
        }
        
       
        
        public static void BloodDonate()
        {
            bool physicalvalid=false;
            Console.WriteLine($"Enter your weight");
            int weight=int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter your Bloodpressure");
            int bloodPressure=int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter your HemoGlobinlevel");
            int hemoGlobinCount=int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter your BloodGroup");
            BloodGroupUpdate blood=Enum.Parse<BloodGroupUpdate>(Console.ReadLine(),true);
            
           
                if(weight>=50 && bloodPressure>=120 && hemoGlobinCount>=13)

                {
                     physicalvalid=true; 
                }
                else
                {
                    Console.WriteLine($"you are not Physically fit to give Donation");
                    
                }
            

            TimeSpan time =new TimeSpan();
            DateTime date = new DateTime();
            string dateConvertion=currentuser.NextEligibleDate();
            date=DateTime.ParseExact(dateConvertion,"dd/MM/yyyy",null);
            time=date.Subtract(DateTime.Now);
            if(physicalvalid==true && time.TotalDays>0)
            {
                Console.WriteLine($"your not Eligible for Giving donation your Next Eligible Date yet to come {currentuser.NextEligibleDate()}");
                
            }
            else if(physicalvalid==true && time.TotalDays<=0)
            {
              Console.WriteLine($"Blood Donation process successfully completed");
              Donation donateupdate=new Donation(currentuser.DonarID,DateTime.Now,weight,bloodPressure,hemoGlobinCount,blood);
               donationList.Add(donateupdate);
               Console.WriteLine($"here is the your Donation Id{donateupdate.DonationID}");
            }
            
            
            

        }

        public static void DonationHistory()
        {

            foreach (Donation donatehistory in donationList)
            {
                    if(currentuser.DonarID == donatehistory.DonarID)
                    {
                    Console.WriteLine($"------------------------------");
                    Console.WriteLine($"DonarID: {donatehistory.DonarID} \nDonationDate :{donatehistory.DonationDate} \nDonationId :{donatehistory.DonationID} \nWeight :{donatehistory.Weight} \nBloodpressure{donatehistory.Bloodpressure} \nHemoglobin{donatehistory.HemoGlobinCount} \nBloodGroup {donatehistory.BloodGroup}");       
                    Console.WriteLine($"------------------------------");
                    }
            }        
        }
    
    }
}