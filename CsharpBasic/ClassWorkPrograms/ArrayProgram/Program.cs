using System;
namespace ArrayProgram 
{
    class Program  
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Enter the Memory Limit");
            int limit=int.Parse(Console.ReadLine());
            string[] StudentDetails= new string[limit];
            for(int GetName=0; GetName<limit; GetName++ )
            {
                Console.WriteLine($"Enter the Name{GetName}");
                
                StudentDetails[GetName]=Console.ReadLine();
                
            }
            Console.WriteLine($"List the Names");
            
            for(int GetName=0; GetName<limit; GetName++)
            {
                Console.WriteLine($"{StudentDetails[GetName]}");
                
            }
            Console.WriteLine($"Enter the Name YOU want to check BY FOR");
            string nameCheck=Console.ReadLine();
            int count=0;
            for(int GetName=0; GetName<limit; GetName++)
            {

                if(nameCheck==StudentDetails[GetName])
                {
                    Console.WriteLine($"name is present{StudentDetails[GetName]} index position{GetName}");
                    count++;
                }

            }
                if(count==0)
                {
                    Console.WriteLine($"name is not present");
                    
                }
        Console.WriteLine($"Enter the NAme you want to check BY FOREACH");
            nameCheck=Console.ReadLine();
            int count1=0,index=0;
            foreach(string GetName in StudentDetails)
            {
                
                if(nameCheck==GetName)
                {
                    
                    Console.WriteLine($"name is present {GetName}");
                    count1++;
                }
                index++;
            }
            if(count1==0)
            {
                Console.WriteLine($"Name is Not Present");
                
            }
             
        }
           
    }
            
 }

