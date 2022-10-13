using System;

namespace MovieBooking
{
    public class UserRegsiteration:Personal,IWallet
    {
        private static int s_userId =1000;
        /// <summary>
        /// UserId
        /// </summary>
        /// <value></value>
        public string UserID { get;}
        /// <summary>
        /// user current Wallet Balance
        /// </summary>
        /// <value></value>

        public double WalletBalance{get;set;}
        public UserRegsiteration(string name, int age, long mobileNumber,double walletBalance):base( name, age, mobileNumber)
        {
            s_userId++;
            UserID="UID"+s_userId;
            WalletBalance=walletBalance;
        }

        public UserRegsiteration(string data)
        {
           string[] values= data.Split(",");
           s_userId = int.Parse(values[0].Remove(0,3));
           UserID=values[0];
           Name = values[1];
           Age=int.Parse(values[2]);
           MobileNumber=long.Parse(values[3]);
           WalletBalance=double.Parse(values[4]);

        }
        public void WalletRecharge(double amount)
        {
            WalletBalance+=amount;
            Console.WriteLine($"Your current Balance of AfterRecharge  Rs.{WalletBalance}");
            
        }
    }

    
}