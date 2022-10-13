using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDataStatic
{
    public static class StudentInfo
    {
        public static string Name { get; set; }
        public static int RegisterNumber;//public so Pascal 
        
        static StudentInfo()// default constructor 
        {
           Name="guru";
           RegisterNumber=1212;
        }
        public static void Display()
        {
            Console.WriteLine($"Name: {Name} \nRegisterNumber : {RegisterNumber}");
            
        }
    }

        /*public class StudentInfo
        {
        private static string names="guru";
        public static string Names {get{return;}}
        public static int RegisterNumber;//public so Pascal
        public string gender="Male" ;
         public  void Display()
         {
            Console.WriteLine($"{Names},{RegisterNumber},{gender}");
            
         }
        }*/
        
        
    }
