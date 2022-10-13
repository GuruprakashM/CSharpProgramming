using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaccinationProcess
{
    public static class Operation
    {
              
        static List<Beneficiary> BeneficiariesList =new List<Beneficiary>();
        static List<Vaccination> VaccinationList =new List<Vaccination>();
        static List<Vaccine> VaccineList =new List<Vaccine>();
        static Beneficiary currentuser=null;

       public static void DefaultSetup()
        {
             Beneficiary beneficiaryFirst= new Beneficiary("guru",21,Gender.Male,"Rajapalaayam",9894999);
             BeneficiariesList.Add(beneficiaryFirst);
             Beneficiary beneficiarySecond= new Beneficiary("Prakash",21,Gender.Male,"Rajapalaayam",9894989);
             BeneficiariesList.Add(beneficiarySecond);

             Vaccine vaccineFirst =new Vaccine(VaccineName.Covidshield,50);
             VaccineList.Add(vaccineFirst);
             Vaccine vaccineSecond =new Vaccine(VaccineName.Covaccine,50);
             VaccineList.Add(vaccineSecond);

             Vaccination vaccinationFirst= new Vaccination("BID1001","CID101",1,new DateTime(2021,11,12));
             VaccinationList.Add(vaccinationFirst);
             Vaccination vaccinationSecond =new Vaccination("BID1001","CID101",2, new DateTime(2021,11,10) );
             VaccinationList.Add(vaccinationSecond);
             Vaccination vaccinationThird =new Vaccination("BID1002","CID102",1,new DateTime(2021,11,23));
             VaccinationList.Add(vaccinationThird);
        }

     
        public static void MainMenu()
        {
          
          DefaultSetup();
          string condition="";
          do
          {
          Console.WriteLine($"Here is the Details of  the Menu");
          Console.WriteLine($"1.Beneficiary Registration \n2.Login \n3.Get vaccine Info \n4.Exit");
          Console.WriteLine($"Enter your choice");
          int choice=int.Parse(Console.ReadLine());
          switch(choice)
          {
            case 1:
            {
              BeneficiaryRegistration();
              break;
            }
            case 2:
            {
              Login();
              break;
            }
            case 3:
            {
              GetVaccineInfo();
              break;
            }
            case 4:
            {
              //Exit
              condition="no";
              break;
            }
          }
          if(condition=="no"){break;}
          Console.WriteLine($"Do you want continue with MainMenu");
          condition=Console.ReadLine();
        
          }while(condition=="yes");

        }
        public static void BeneficiaryRegistration()
        {
          Console.WriteLine($"Enter your Name");
          string name=Console.ReadLine();
          Console.WriteLine($"Enter your Age");
          int age=int.Parse(Console.ReadLine());
          
          Console.WriteLine($"Enter your Gender");
          Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
          Console.WriteLine($"Enter your City");
          string city=Console.ReadLine();
          Console.WriteLine($"Enter your mobile Number ");
          long mobileNumber=long.Parse(Console.ReadLine());
          Beneficiary beneficiary=new Beneficiary(name,age,gender,city,mobileNumber);
          BeneficiariesList.Add(beneficiary);        
          Console.WriteLine($"Your Registration Successfully Completed");
          Console.WriteLine($"Your RegistrationId is : {beneficiary.RegisterNumber}");
          
        }
         public static void Login()
        {
          Console.WriteLine($"Enter your RegisterationID");
          string RegistrationId=Console.ReadLine();
          int count=0;
          foreach(Beneficiary beneficiary in BeneficiariesList)
          {
            if(beneficiary.RegisterNumber==RegistrationId)
            {
              currentuser=beneficiary;
              Console.WriteLine($"You have Successfully Logined");
              count++;
              SubMenu();
              

            }
          }
          if(count==0)
          {
            Console.WriteLine($"Invaild RegisterNUmber check it once");
            
          }
          
        }

        public static void  GetVaccineInfo()
        {
            Console.WriteLine($"Here is the vacination list ");
            
            Console.WriteLine($"-------------------------------\n");
            foreach( Vaccine getInfo in VaccineList)
            {
          
             Console.WriteLine($"vaccineID : {getInfo.VaccineID} \nVaccineName : {getInfo.VaccineName}  \nNo of AvailabkeDose : {getInfo.NoOfAvailableDose} \n");
             
    
             
             
            }
            Console.WriteLine($"To plan your Vaccination Today {DateTime.Now.ToShortDateString()}");
            Console.WriteLine($"--------------------------------------------------\n");
          
            

        }    
        public static void SubMenu()
        {
          string condition="";
          do
          {
                Console.WriteLine($"Here is the details of Submenu");
                Console.WriteLine($"-----------------------------------------");
                
                Console.WriteLine($"1.Show My Details \n2.TakeVaccination \n3.Vaccination History \n4.Next DueDate \n5.EXit");
                Console.WriteLine($"------------------------------------------");
                Console.WriteLine($"Enter your Choice");
                int choice=int.Parse(Console.ReadLine());

            switch(choice)
              {
                    case 1:
                    {
                      ShowMyDetails();
                      break;
                    }
                    case 2:
                    {
                      TakeVaccination();
                      break;
                    }
                    case 3:
                    {
                      VaccinationHistory();
                      break;
                    }
                    case 4:
                    {
                      NextDueDate();
                      break;
                    }
                    case 5:
                    {
                      //Exit();
                      condition="no";
                      break;
                    }
              }
              if(condition=="no") {break;}
              Console.WriteLine($"Do you want to continue with Submenu");
              condition=Console.ReadLine();
              
              
          
        }while(condition== "yes");
      }
       public static void ShowMyDetails()
       {
         foreach(Beneficiary showDetail in BeneficiariesList)
         {
           if(currentuser.RegisterNumber==showDetail.RegisterNumber)
           {
             Console.WriteLine($"Name:{showDetail.Name} \nyour RegisterationId: {showDetail.RegisterNumber} \nAge:{showDetail.Age} \nGender: {showDetail.Gender} \nMobileNumber:{showDetail.MobileNumber} \nCity: {showDetail.City}");
           
           }
         }
       }
       public static void TakeVaccination()
       {
            Console.WriteLine($"Here is the Datails Avalilable Vaccines List");
            GetVaccineInfo();
            Console.WriteLine($"Enter the VaccineId you want To inject");
            string vaccineInjectId=Console.ReadLine();
            bool uservalid=false;
            bool userRegvalid=false;
            bool vaccinationidgenerate=false;
            int dosenumber=0;
            int userdoseupdate=0;
            
            //check vaccination id
             

            foreach(Vaccine check in VaccineList)
            {
                 if(vaccineInjectId==check.VaccineID)
                 {
                     if(check.NoOfAvailableDose>=1)
                     {
                      Console.WriteLine($"further process going on");
                      
                     }
                   break;  
                 }
                 else
                 {
                  Console.WriteLine($"Invalid vaccine ID");
                  break;
                 }
            }
            //user exist or not
           foreach(Vaccination uservalidcheck in VaccinationList)
           {
               if((currentuser.RegisterNumber==uservalidcheck.RegisterNumber))
               {
                  userRegvalid=true;
                  if(vaccineInjectId==uservalidcheck.VaccineID && userRegvalid==true)
                  {
                     uservalid=true;
                  }
                  else
                  {
                    Console.WriteLine($"dose selection not same with exist dose");
                    break;
                  }
               }
              
           }
      

           //number dose check
        
           if(uservalid==true && userRegvalid==true)
           {
            foreach(Vaccination dosecheck in VaccinationList)
            {
              if(currentuser.RegisterNumber==dosecheck.RegisterNumber)
              {
                dosenumber=dosecheck.DoseNumber;
              }
            }
           }
        foreach (Vaccine dosestock in VaccineList)
        {
          if(vaccineInjectId==dosestock.VaccineID)
          {
              if(uservalid==true && userRegvalid==true && dosenumber==3)
              {
                Console.WriteLine($"You have completed all your dose you can't get vaccinated as of now");
                
              }
              else if(uservalid==true && userRegvalid==true&& dosenumber==2)
              {
                userdoseupdate=dosenumber+1;
                Console.WriteLine($"your third dose successfully get vaccinated");
                dosestock.NoOfAvailableDose--;
                vaccinationidgenerate=true;
                
              }
              else if(uservalid ==true && dosenumber==1)
              {
                userdoseupdate=dosenumber+1;
                Console.WriteLine($"your second dose Successfully get vaccinated");
                dosestock.NoOfAvailableDose--;
                vaccinationidgenerate=true;
              }
              else if(uservalid==false && userRegvalid==false)
              {
                userdoseupdate=dosenumber+1;
                Console.WriteLine($"your first dose Successfully get vaccinated");
                dosestock.NoOfAvailableDose--;
                vaccinationidgenerate=true;
              }
          } 
         
         
          
        }   

      if(vaccinationidgenerate==true)
      {
            
      Vaccination vaccinationnewupdate =new Vaccination(currentuser.RegisterNumber,vaccineInjectId,userdoseupdate,DateTime.Now);
     VaccinationList.Add(vaccinationnewupdate);
     Console.WriteLine($"your vaccination id is {vaccinationnewupdate.VaccinationID}");
     DateTime date=new DateTime();
     date=DateTime.Now.AddDays(30);
     Console.WriteLine($"your Next Vaccination Date{date.ToShortDateString()}");
     
      }         
          
           
        
    }
       public static void VaccinationHistory()
       {
            Console.WriteLine($"HERE IS THE DETAILS OF {currentuser.RegisterNumber}");
            Console.WriteLine($"-------------------------------------------------------\n");
            
             foreach (Vaccination vaccinationhistory in VaccinationList)
             {
              if(currentuser.RegisterNumber==vaccinationhistory.RegisterNumber)
              {
                
                Console.WriteLine($"vaccination ID : {vaccinationhistory.VaccinationID}  \nRegisterationNumber : {vaccinationhistory.RegisterNumber} \nVaccineId :{vaccinationhistory.VaccineID} \nDosenumber: {vaccinationhistory.DoseNumber} \nvaccinationdate{vaccinationhistory.VaccinatedDate} \n");
                
                
              }
             }
             Console.WriteLine($"------------------------------------------------------------");
             
       }
       public static void NextDueDate()
       {
        DateTime date =new DateTime();
        int dosenumber =0;
         foreach (Vaccination Nextdue in VaccinationList)
         {
            if(currentuser.RegisterNumber == Nextdue.RegisterNumber)
            {
            
              
              date=DateTime.ParseExact("02/10/2022","dd/MM/yyyy",null);
              dosenumber=Nextdue.DoseNumber;

            }
         }
         if(dosenumber==1)
         {
           date=date.AddDays(30);
           Console.WriteLine($"your Second vaccination  date {date.ToLongDateString()}");
           
         }
         else if(dosenumber==2)
         {
           date=date.AddDays(30);
           Console.WriteLine($"your third vaccination  date {date.ToLongDateString()}");
         }
         else if(dosenumber==3)
         {
         Console.WriteLine($"you have finished all your dose");
         Console.WriteLine($"THANK FOR PARTICIPATION OF VACCINATION DRIVE");
         
         
         }
         else
         {
          Console.WriteLine($"You can get vaccinated now");
          
         }

       }
    }
}