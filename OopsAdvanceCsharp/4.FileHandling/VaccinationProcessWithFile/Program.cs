using System;
namespace VaccinationProcess
{
    class Program 
    {
        public static void Main(string[] args)
        {
            FIles.CreateFile();
            FIles.ReadFiles();
            Operation.MainMenu();
            FIles.WriteFiles();
        }
    }
}