using System;
namespace AbstractClasses 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Syncfusion syncfusion = new Syncfusion();
            Console.WriteLine($"---Syncfusion----");
            syncfusion.Name="guru";
            syncfusion.Salary(30);
            Tcs tcs = new Tcs();
            Console.WriteLine($"---TCS------------"); 
            tcs.Name="gurup";
            tcs.Salary(30);

            Console.ReadLine();
            
        }
    }
}
