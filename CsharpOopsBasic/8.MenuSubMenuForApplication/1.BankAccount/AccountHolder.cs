using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//XML TAGS
/// <summary>
/// used to process of the Bank Account Opening
/// </summary>
namespace BankAccount
{
    /// <summary>
    /// used to click the options of the Gender
    /// </summary>
    public enum Gender {Default,Male,Female,Transgender}
    /// <summary>
    ///<see cref="AccountType"/>used to specify the Account Type
    /// </summary>
    public enum AccountType{Default,Savings,Current,FD,RD}
    /// <summary>
    /// class <see cref="AccountHolder"/>used to collect the datas
    /// </summary>
    public class AccountHolder
    {

        /// <summary>
        ///  Account Number details
        /// </summary>
        public static long AccountNumber=44444;
        /// <summary>
        /// AccountHolder Name
        /// </summary>
  
        public string Name { get; set; }//property
        /// <summary>
        /// AccountHolder's Father Name
        /// </summary>
     
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DoB{ get; set; }
        /// <summary>
        /// which type of account 
        /// </summary>
       
        public AccountType AccountType { get; set; }
        public double Balance{ get; set; }
       /// <summary>
       /// Default constructors
       /// </summary>
        public AccountHolder()//default Constructors
        {
            Balance=0.0;
        }
        //Parameterised constructors
        
       /// <summary>
       ///  AccountHolder
       /// </summary>
       /// <param name="name">user name passing to property</param>
       /// <param name="fatherName">user father name passing to property</param>
       /// <see cref ="name"/>
       /// <param name="gender">user gender details</param>
       /// <param name="dob">Date of bith</param>
       /// <param name="accountType">Account type</param>
        public AccountHolder(String name,string fatherName,Gender gender, DateTime dob,AccountType accountType)
        
        {
            AccountNumber++;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            DoB=dob;
            AccountType=accountType;
        }
        /// <summary>
        /// Give the details about Deposit amount details
        /// </summary>
        public void Deposite()///Deposite purpose
        {

            Console.WriteLine($"Enter the deposit amount");
            double deposit=double.Parse(Console.ReadLine());
            Balance=Balance+deposit;

            
        }
        /// <summary>
        /// Get the amount you want purpose
        /// </summary>
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
        /// <summary>
        /// Just Show Balance amount Details
        /// </summary>
        public void Balances()
        {
            Console.WriteLine($"-------------------------");
            Console.WriteLine($"Balance amount {Balance}");
            Console.WriteLine($"---------------------------------");
            WithDraw();
            
            
        }
        /// <summary>
        /// just Show the details about User
        /// </summary>
         public void ShowDetails()
         {
            Console.WriteLine($"-----------------------------");
            Console.WriteLine($"Here your details");
            Console.WriteLine($"--------------------------------");
            Console.WriteLine($"A/cNumber:{AccountNumber} \nName :{Name} \nFatherName :{FatherName} \nGender :{Gender} \nDOB: {DoB} \nAccountype: {AccountType}");
            Console.WriteLine($"--------------------------------");
            
            
         }

    }
}