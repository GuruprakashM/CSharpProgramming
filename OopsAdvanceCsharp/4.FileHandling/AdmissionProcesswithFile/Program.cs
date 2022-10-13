using System;
using System.Linq;

namespace AdmissionProcess 
{
    class Program 
    {
        public static void Main(string[] args)
        {
         Files.Create();
         Files.ReadFile();
         Opreations.Mainmenu();
         Files.WritetoFiles(); 
        }
    }
}
