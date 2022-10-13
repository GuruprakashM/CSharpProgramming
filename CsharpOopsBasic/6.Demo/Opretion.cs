using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo
{
    public  static class Opretion
    {
        public static void MainMenu()
        {
            //TimeSpan time =new TimeSpan();
            DateTime date =new DateTime();
            date=DateTime.Today.AddDays(40);
            Console.WriteLine($"date{date.ToShortDateString()}");
            
        }
        
    }
}