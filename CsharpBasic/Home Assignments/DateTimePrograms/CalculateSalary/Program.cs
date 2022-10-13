using System;
namespace CalculateSalary;
class Program 
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine($"Enter the month");
        int month=int.Parse(Console.ReadLine());
        int days= DateTime.DaysInMonth(2022,month);
        Console.WriteLine($"Enter the  number days leave taken");
        int leave=int.Parse(Console.ReadLine());
        double salary=(days-leave)*500;
        Console.WriteLine($"Salary of this month  is {salary}");
    
    }
}