using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBooking
{
    public interface IWallet
    {
        double WalletBalance{get;set;}
        void WalletRecharge(double amount);
    }
}