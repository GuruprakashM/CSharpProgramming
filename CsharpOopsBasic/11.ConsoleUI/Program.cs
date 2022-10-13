using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Please note - THIS IS A BAD APPLICATION - DO NOT REPLICATE WHAT IT DOES
// This application was designed to simulate a poorly-built application that
// you need to support. Do not follow any of these practices. This is for 
// demonstration purposes only. You have been warned.
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string whatDone="";
            int i;
            double hoursWorked=0, totalTime=0;
            List<TimeSheetEntry> entries = new List<TimeSheetEntry>();
            Console.Write("Enter where you finshed work ");
            whatDone = Console.ReadLine();
            Console.Write("How long did you do it for: ");
             hoursWorked = double.Parse(Console.ReadLine());
            TimeSheetEntry entry = new TimeSheetEntry();
            entry.HoursWorked =hoursWorked;
            entry.WorkDone = whatDone;
            entries.Add(entry);
            Console.Write("Do you want to enter more time:");
            string choice = Console.ReadLine().ToLower();
            while(choice =="yes")
            {
                TimeSheetEntry entry1 = new TimeSheetEntry();
                Console.Write("Enter where ");
                whatDone = Console.ReadLine();
                Console.Write("How long did you do it for: ");
               hoursWorked = double.Parse(Console.ReadLine());
                entry1.HoursWorked =hoursWorked;
                entry1.WorkDone = whatDone;
                entries.Add(entry1);
                Console.Write("Do you want to enter more time:");
                choice = Console.ReadLine().ToLower();
            } 
          
            for (i= 0; i < entries.Count; i++)
            {
                
                if (entries[i].WorkDone.ToLower().Contains("acme"))
                {
                    totalTime += entries[i].HoursWorked;
                }
            }
            Console.WriteLine("Simulating Sending email to Acme");
            Console.WriteLine("Your bill is $" + totalTime * 150 + " for the hours worked.");
            totalTime=0;
            for (int j = 0; j < entries.Count; j++)
            {
                if (entries[j].WorkDone.ToLower().Contains("abc"))
                {
                    totalTime += entries[j].HoursWorked;
                }
            }
            Console.WriteLine("Simulating Sending email to ABC");
            Console.WriteLine("Your bill is $" + totalTime * 125 + " for the hours worked.");
            totalTime=0;
            for (int k = 0; k < entries.Count; k++)
            {
                totalTime += entries[k].HoursWorked;
            }
            if (totalTime>40)
            {
                Console.WriteLine( $" you will get the paid ${(400+((totalTime-40)*15))}");
                

            }
            else
            {
                Console.WriteLine("You will get paid $" + totalTime * 15 + " for your time.");
            }
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }
    }

    public class TimeSheetEntry
    {
        public string WorkDone;
        public double HoursWorked;
    }
}
