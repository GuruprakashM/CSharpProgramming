using System;

namespace AccountHolderLibrary
{
    public enum Gender {Default,Male,Female,Transgender}
    public enum AccountType{Default,Savings,Current,FD,RD}
    public class AccountHolder
    {
    
        public string Name { get; set; }//property
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DoB{ get; set; }
        public AccountType AccountType { get; set; }
       
        public double Balance{ get; set; }
        public AccountHolder()//default Constructors
        {
            Balance=0.0;
        }
        //Parameterised constructors
        public AccountHolder(String name,string fatherName,Gender gender, DateTime dob,AccountType accountType)
        
        {
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            DoB=dob;
            AccountType=accountType;
        }
        public void Deposite()
        {

            Console.WriteLine($"Enter the deposit amount");
            double deposit=double.Parse(Console.ReadLine());
            Balance=Balance+deposit;

            
        }
        public void WithDraw()
        {
            

           Console.WriteLine($"ENter the withdraw amount");
           double withdraw=double.Parse(Console.ReadLine());
            if(Balance>=withdraw)
                 {
                Balance=Balance-withdraw;
                 }
             else
               {
                Console.WriteLine($"Not required Balance Avalibale");
                
               }
            
        }
        public void Balances()
        {
            
            Console.WriteLine($"Balanace amount {Balance}");
            
        }

    }
}