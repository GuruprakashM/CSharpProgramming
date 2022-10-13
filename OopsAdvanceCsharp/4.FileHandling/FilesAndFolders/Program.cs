using System;
using System.IO;
namespace FileAndFolders
{
    class Program 
    {
        public static void Main(string[] args)
        {
            string path=@"C:\Users\GuruprakashMurugaBoo\OneDrive - Syncfusion\Desktop\MyFolder";
            string folderPath=path+"/guru";
            string filePath=path+"/newFile.txt";
            //Directory.Create
            if(!Directory.Exists(folderPath))
            {
                Console.WriteLine($"Folder doesn't Exist so new Folder  Successfully Created ");
                Directory.CreateDirectory(folderPath);
                
            }
            else 
            {
                Console.WriteLine($"Folder already Found");
                
            }
            if(!File.Exists(filePath))
            {
                Console.WriteLine($"File doesn't Exit so new File SuccessFully Created");
                File.Create(filePath);
                
            }
            else
            {
                Console.WriteLine($"File Already Found");
                
            }

           Console.WriteLine($"Selection Options 1.Create Folder \n2.Create File \n3.Delete Folder \n4.Delete File ");
           int choice=int.Parse(Console.ReadLine());
           switch(choice)
           {
              case 1:
              {
                Console.WriteLine($"Enter folder name You want to create ");
                string name=Console.ReadLine();
                string newPath=path+"\\"+name;
                if(!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                else 
                {
                    Console.WriteLine($"Folder name already Exists");
                    
                }
                
                break;
              }
              case 2:
              {
                Console.WriteLine($"Enter the File Name you want");
                string fileName=Console.ReadLine();
                Console.WriteLine($"Enter the File Extension Type");
                string extension=Console.ReadLine();
                string newPath=path+"\\"+fileName+"."+extension;
                if(!File.Exists(newPath))
                {
                    File.Create(newPath);
                }
                else
                {
                    Console.WriteLine($"File Already Exist");
                    
                }
                
                break;
              }
              case 3:
              {
                foreach(string name in Directory.GetDirectories(path))
                {
                    Console.WriteLine(name);
                }
                    Console.WriteLine("Select folder you want to delete");
                    string name1= Console.ReadLine();
                    string newPath=path+"//"+name1;

                foreach(string name in Directory.GetDirectories(path))
                {
                    if(name==newPath)
                    {
                          try
                          {
                               Directory.Delete(newPath);
                               Console.WriteLine($"FolderDeleted");
                               
                          }
                          catch(DirectoryNotFoundException e)
                          {
                            Console.WriteLine($"Directory not Found {e.Message}");
                            
                          }
                    }
                }
                
                break;
              }
              case 4:
              {
                foreach(string name in Directory.GetFiles(path))
                {
                    Console.WriteLine(name);
                }
                    Console.WriteLine("Select folder you want to delete");
                    string name1= Console.ReadLine();
                    string newPath=path+"//"+name1;

                foreach(string name in Directory.GetDirectories(path))
                {
                    if(name==newPath)
                    {
                          try
                          {
                               Directory.Delete(newPath);
                               Console.WriteLine($"FolderDeleted");
                               
                          }
                          catch(DirectoryNotFoundException e)
                          {
                            Console.WriteLine($"Directory not Found{e.Message}");
                            
                          }
                    }
                }
               break;
              }
           }

        }
    }
}
