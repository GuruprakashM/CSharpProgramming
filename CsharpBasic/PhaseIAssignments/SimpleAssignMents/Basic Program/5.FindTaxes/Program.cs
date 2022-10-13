using System;
namespace FindTaxes 
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"ENter the basic salary");
            double salary=Convert.ToDouble(Console.ReadLine());
            double dA=salary*0.1f;
            double hra=salary*0.1f;
            double MonthlySalary=salary+dA+hra;
            double annualSalary=MonthlySalary*12;
            double annualIncome=annualSalary-(annualSalary*0.05f);
            Console.WriteLine($"The Annual income is {annualIncome}");
            
            
        }
    }
}
