using System;
namespace ProductTax 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int price;
            double tax;
            Console.WriteLine("Enter your price details");
            price=int.Parse(Console.ReadLine());
            tax=price+ (price*0.18f);
            Console.WriteLine("The Tax details of your Product prize "+tax);

        }
    }
}
