using System;
namespace ConvertMoneyFromCurrency
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the indian money");
            int indianMoney=int.Parse(Console.ReadLine());
            double USD=indianMoney*0.0122f;
            double EUR=indianMoney*0.0122f;
            double CNY=indianMoney*0.0879f;
            Console.WriteLine($"The USD is{USD} \nThe EUR is{EUR} \nThe CNY is{CNY}");
            
            
        }
    }
}
