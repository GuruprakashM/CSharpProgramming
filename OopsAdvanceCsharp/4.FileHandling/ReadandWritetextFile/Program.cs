using System;
using System.IO;
namespace ReadAndWritetextFile 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            if(!Directory.Exists("TestFolder"))
            {
               Directory.CreateDirectory("TestFolder");
               Console.WriteLine($"Folder Created");
               
            }
            else 
            {
                Console.WriteLine($"Folder Already Exist");
                
            }
            if(!File.Exists("TestFolder/Test.txt"))
            {
                File.Create("TestFolder/Test.txt");
                Console.WriteLine($"File created");
                
            }
            else
            {
                 Console.WriteLine($"File Already Exist");
                 
            }
            Console.WriteLine($"Select the option 1.Read file Info \n2.Write file Info");
            int choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    Console.WriteLine($"ReadLine concept");
                    //Read Line in text file
                    string line;
                    StreamReader sr=null;
                    try
                    {
                        sr=new StreamReader("TestFolder/Test.txt");
                        line=sr.ReadLine();
                        while(line!=null)
                        {
                            Console.WriteLine($"{line}");
                            line=sr.ReadLine();
                            
                        }

                    }
                    catch(Exception e) 
                    {
                        Console.WriteLine($"Exception : {e.Message}");
                        
                    }
                    finally
                    {
                        if(sr!=null)
                        {
                            Console.WriteLine($"Execute the Finally Block");
                            sr.Close();
                            
                        }
                    }
                    break;
                }
                case 2:
                {
                    Console.WriteLine($"WriteLine Concept");
                    StreamWriter sw =null;
                   try
                   {
                     
                      string[] old=File.ReadAllLines("TestFolder/Test.txt");
                      sw = new StreamWriter("TestFolder/Test.txt");
                      Console.WriteLine($"Enter new content to be Placed in file");
                      string info =Console.ReadLine();
                      string old1 ="";
                      foreach(string text in old)
                      {
                        old1=old1+"\n"+text;
                      }
                      old1=old1+info;
                      sw.WriteLine(old1);
                      

                   }
                   catch(Exception e)
                   {
                          Console.WriteLine($"Exception : {e.Message}");
                          
                   }
                   finally
                   {
                     if(sw!=null)
                     {
                        sw.Close();
                     }
                   }
                    
                    break;
                }
            }
            
        }
    }
}
