using System;
using System.Collections.Generic;
namespace FilterDelegates
 {
    class program 
    {
        public static void Main(string[] args)
        {
            Person personOne = new Person() {Name ="Guruprakash",Age=11};
            Person personTwo = new Person() {Name ="Ravi",Age=31};
            Person personThree = new Person() {Name ="Ram",Age=41};
            Person personFour= new Person() {Name ="Jeeva",Age=51};
            Person personFive = new Person() {Name ="John",Age=71};
            Person personSix = new Person() {Name ="Suresh",Age=81};
            List<Person> people = new List<Person>(){personOne,personTwo,personThree,personFour,personFive,personSix};
            Console.WriteLine();
            
            DisplayPeople("Children",people,IsChild);
            Console.WriteLine($"---------------------------");
            
            DisplayPeople("voter",people,IsVoter);
            Console.WriteLine($"----------------------------");
            
            DisplayPeople("Adult",people,IsAdult);
            Console.WriteLine($"-----------------------------");
            
            DisplayPeople("Seniors",people,IsSenior);
            Console.WriteLine($"-----------------------------");
            
         
        }
        
          public static void DisplayPeople(string title, List<Person> people,FilterDelegate filter)
        {
            Console.WriteLine("People in" +title+ " list are");
            foreach(Person p in people)
            {
                if(filter(p))
                {
                    Console.WriteLine($"{p.Name} is {p.Age} old");
                    
                }
            }

            
        }

        static bool IsChild(Person p) {return p.Age<15;} // IsChild is the Filter Delegates
        static bool IsVoter(Person p) {return p.Age>=18;}

        static bool IsAdult(Person p ){ if (p.Age>=18 && p.Age <50) {return true; } else {return false;}}
        static bool IsSenior(Person p) {return p.Age>=50;}
    }
 }