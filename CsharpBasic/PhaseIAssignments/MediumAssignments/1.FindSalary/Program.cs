using System;
namespace FindSalary 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the salary");
            int salary=int.Parse(Console.ReadLine());
            double annualCrossSalary=0,TakeHomeSalary=0,salaryMonth=0,TakeHomeSalaryMonth=0;
            if(salary<=10000)
            {
                 annualCrossSalary=(salary+(salary*0.2f*0.8))*12;
                 TakeHomeSalary=(annualCrossSalary-(annualCrossSalary*0.06*0.01));
                  salaryMonth=salary+(salary*0.2f*0.8f);
                Console.WriteLine($"{salaryMonth}");
                TakeHomeSalaryMonth=(salaryMonth-((salaryMonth*0.06*0.01)/12f));
                 Console.WriteLine($"The Annual CrossSalary is : Rs.{annualCrossSalary} \nThe Take Home Salary/year : Rs.{TakeHomeSalary}");
                 Console.WriteLine($"The take home salary/Month : Rs.{TakeHomeSalaryMonth}");
                 
                 
            }
            
        }
    }
}