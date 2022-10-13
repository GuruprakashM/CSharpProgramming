using System;
using System.IO;
using System.Collections.Generic;
namespace ListFileManuplation
{
    class Program 
    {
        
        public static void Main(string[] args)
        {
         
        List<StudentDetails> slist = new List<StudentDetails>();
        slist.Add( new StudentDetails() {Name="guru",FatherName ="Murugaboopathi", Gender=Gender.Male,BirthDate = new DateTime(1998,10,30)});
        slist.Add( new StudentDetails() {Name="Prakash",FatherName ="Murugaboopathi", Gender=Gender.Male,BirthDate = new DateTime(1998,10,15)});
        slist.Add( new StudentDetails() {Name="guruprakash",FatherName ="Murugaboopathi", Gender=Gender.Male,BirthDate = new DateTime(1998,10,15)});
        Insert(slist);
        Display();
        Update();
        }
        static void Insert(List<StudentDetails> slist)
        {
            StreamWriter write =null;
            if(!File.Exists("Data.csv"))
            {
                Console.WriteLine($"File doesn't exit . creating new file");
                File.Create("Data.csv");
                
            }
            else
            {
                Console.WriteLine($"File Already Found");
                
            }
            write = new StreamWriter(File.OpenWrite("Data.csv"));
            foreach (var v in slist)
            {
                write.WriteLine(v.Name+","+v.FatherName+","+v.Gender+","+v.BirthDate.ToShortDateString());
            }
            write.Close();

        }

        static void Display()
        {
            StreamReader reader=null;
            List<StudentDetails> listA = new List<StudentDetails>();
            if(File.Exists ("Data.csv"))
            {
                reader = new StreamReader(File.OpenRead("Data.csv"));
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values =line.Split(",");
                    if(values[0]!="")
                    {
                        listA.Add(new StudentDetails() {Name=values[0],FatherName=values[1],Gender=Enum.Parse<Gender>(values[2]),BirthDate=DateTime.ParseExact(values[3],"dd/MM/yyyy",null)});
                    }
                }
            }
            else 
            {
              Console.WriteLine($"File doesn't exist");
              
            }
            reader.Close();
            foreach(var show in listA)
            {
                Console.WriteLine("yourName :\t" +show.Name+"\t FatherName :\t"+show.FatherName+"\t Gender is \t"+show.Gender+"\t DateOfBirth :\t"+show.BirthDate.ToString("dd/MM/yyyy"));
                
            }

        }

        static void Update()
        {
            List<StudentDetails> students = new List<StudentDetails>();
            string[] get=File.ReadAllLines("Data.csv");
            Console.WriteLine($"Enter the option 1.Name \n2.FatherName");
            int option=int.Parse(Console.ReadLine());
            Console.WriteLine($"What you want to update the name");
            string name=Console.ReadLine();
            
             foreach(var each in get)
              {
                        string[] check=each.Split(",");
                        switch(option)
                        {
                            case 1:
                            {
                                    if(check[0]!=name)
                                    {
                                        check[0]=name;
                                     
                                    }         
                            } 
                            break;
                            case 2:
                            {
                                    if(check[1]!=name) 
                                    {        
                                       check[1]=name;
                                    }    
                                
                             }
                             break; 
                          }
                          string [] lines = new string[students.Count];
                          for(int i=0; i<students.Count; i++)
                          {
                          
                           lines[i]=check[0] +","+check[1]+","+Enum.Parse<Gender>(check[2],true)+","+DateTime.ParseExact(check[3],"dd/MM/yyyy",null);
                          }
                           File.AppendAllLines("Data.csv",lines);
                    }  
               
             
        
         }
    }


}     //File.WriteLines("Data.csv",lines);