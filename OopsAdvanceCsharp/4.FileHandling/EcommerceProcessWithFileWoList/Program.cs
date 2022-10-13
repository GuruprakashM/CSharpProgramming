using System;
namespace EcommerceProcess
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Files.Create();
            Files.ReadFile();
            Opreation.MainMenu();
            Files.WriteFile();
        }
    }
}