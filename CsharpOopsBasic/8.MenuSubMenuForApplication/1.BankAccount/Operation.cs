using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount
{
    public static class Operation
    {
         static List<AccountHolder> accountHolderlist= new List<AccountHolder>();
         static AccountHolder Empty=null;
         public static void MainManu()

         {
            string condition="yes";
           do {
            Console.WriteLine($"Here the choice of MainMenu");
            Console.WriteLine($"1.Register \n2.Login \n3.Exit");
            Console.WriteLine($"Enter your Choice");
            int choice =int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    Console.WriteLine($"----------------------------");
                    Console.WriteLine($"Registeration Form");
                     Console.WriteLine($"----------------------------");
                    Register();
                    break;
                }
                case 2:
                {
                    Login();
                    break;

                }
                case 3:
                {
                    condition="no";
                    Console.WriteLine($"--------THANKYOU-----------");
                    break;
                }
            }
            
           }while(condition=="yes");   
            
         }
         public static void Register()
         {
            Console.WriteLine($"Enter the Name");
            string name=Console.ReadLine();
            Console.WriteLine($"Enter the fatherName");
            string fatherName=Console.ReadLine();
            Console.WriteLine($"Enter the Gender");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            Console.WriteLine($"Enter the Date of Birth");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.WriteLine($"Enter the AccountType");
           AccountType accountType=Enum.Parse<AccountType>(Console.ReadLine(),true);
    
            AccountHolder holder= new AccountHolder(name,fatherName,gender,dob,accountType);
            accountHolderlist.Add(holder);
            
            Console.WriteLine($"------------------------------------------------>");
            
            Console.WriteLine($"Your Account has been successfully Activated");
    
         }
         public static void Login()
         {
                Console.WriteLine($"Enter your ACCOUNT NUMber");
                long Acnumber=long.Parse(Console.ReadLine());
                Console.WriteLine($"Enter your Password");
                string Password=Console.ReadLine();
                foreach(AccountHolder account in accountHolderlist)
                {
                    Empty=account;
                    if((AccountHolder.AccountNumber==Acnumber) &&(account.Name.Remove(4)==Password))
                    {
                        Console.WriteLine($"------------------>");
                        
                        Console.WriteLine($"You have been succesfully logined");
                        Console.WriteLine($"<----------------------");
                        
                        SubMenu();
                    }
                    else
                    {
                        Console.WriteLine($"Invaild entry check a/c Number or password");
                        
                    }
                }
                
                
         }
         public static void SubMenu()
         {
            string condition="yes";
            do 
            {
            
            Console.WriteLine($"Here is the choice of SubMenu");
            Console.WriteLine($"1.ShowDetails \n2.Deposit \n3.WithDraw \n4.ShowBalance() \n5.Exit");
            Console.WriteLine($"Enter your Choice");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    Empty.ShowDetails();
                    break;
                }
                case 2:
                {
                    Empty.Deposite();
                    break;

                }
                case 3:
                {   Empty.WithDraw();
                    break;
                }
                case 4:
                {
                    Empty.Balances();
                    break;
                }
                case 5:
                {
                    condition="no";
                    break;
                }
            }
            }while(condition=="yes");
            
         }
    
    
    
    
    }
}