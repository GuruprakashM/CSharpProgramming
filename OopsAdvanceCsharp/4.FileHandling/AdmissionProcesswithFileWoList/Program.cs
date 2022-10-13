using System;
using System.Linq;
using System.Collections.Generic;
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
