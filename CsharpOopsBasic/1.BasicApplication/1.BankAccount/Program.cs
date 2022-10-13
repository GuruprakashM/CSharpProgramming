using System;
using System.Collections.Generic;
namespace BankAccount 
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<AccountHolder> accountHolderlist= new List<AccountHolder>();
            string condition="";
          
            do{

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

            Console.WriteLine($"Your Account has been successfully Activated");
    
            Console.WriteLine($"Do you want to continue");
            condition=Console.ReadLine();
            }while(condition=="yes");

            foreach (AccountHolder holderData1 in accountHolderlist)
            {
                Console.WriteLine($"---------------------------------------");
                
                Console.WriteLine($"THE ACCOUNT DETAILS OF {holderData1.Name}");
                Console.WriteLine($"---------------------------------------");
                Console.WriteLine($"Name: {holderData1.Name} \nFatherName :{holderData1.FatherName} \nGender :{holderData1.Gender} \nDateofBirth :{holderData1.DoB.ToShortDateString()} \nAccountType: {holderData1.AccountType} \nYour current Balance :{holderData1.Balance}");
                Console.WriteLine($"---------------THANK YOU----------------");
                holderData1.Deposite();
                holderData1.WithDraw();
                holderData1.Balances();
            }
        }
    }
}