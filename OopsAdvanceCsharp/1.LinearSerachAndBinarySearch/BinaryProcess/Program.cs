using System;
namespace BinaryProcess
{
    class program 
    {
        public static void Main(string[] args)
        {
            program pro =new program();
         
            int[] array ={2,3,1,56,45,23,34,78};
            Array.Sort(array);
            int [] arraysort=new int[array.Length];
            for(int output=0; output<array.Length; output++)
            {
                arraysort[output]=array[output];
            }
            Console.WriteLine($"array Sorted output");
            foreach( int output in arraysort)
            {
                Console.Write($"{output} ");
                
           
            }
            Console.WriteLine($"Enter the target value");
            int target=int.Parse(Console.ReadLine()); 
            if(pro.arrayindex(arraysort,target)!=0)
            {
            Console.WriteLine($"the  index position of {target} is {pro.arrayindex(arraysort,target)}");
            }
            else
            {
                Console.WriteLine($"the value doesn't exit");
                
            }

            char[] arraychar ={'A','B','C','D','E','F','M'};
            Console.WriteLine($"Enter the target char");
            char targetchar=char.Parse(Console.ReadLine());
             if(pro.arraycharindex(arraychar,targetchar)!=-1)
            {
            Console.WriteLine($"the  index position of {targetchar} is {pro.arraycharindex(arraychar,targetchar)}");
            }
            else
            {
                Console.WriteLine($"the value doesn't exit");
                
            }
            string [] arraystring ={"SF3001","SF3002","SF3003","SF3004"};
            Console.WriteLine($"Enter the target char");
            string targetstring=(Console.ReadLine());
             if(pro.arraystringindex(arraystring,targetstring)!=-1)
            {
            Console.WriteLine($"the  index position of {targetstring} is {pro.arraystringindex(arraystring,targetstring)}");
            }
            else
            {
                Console.WriteLine($"the value doesn't exit");
                
            }
        }
        public int arrayindex(int [] arraysort, int target)
        {
            int start=0;
            int end=arraysort.Length;
      
                
                    while(start<=end)        
                        {
                            int mid=(start+end)/2;
                            if(arraysort[mid]==target)
                            {
                                return mid;
                                
                            }
                            else  if(arraysort[mid]>target)
                            {
                                end=mid-1;
                                
                            
                            }
                            else if(arraysort[mid]<target)
                            {
                                start=mid+1;
                           
                            
                            }
                
                        }
                        return  0;
                
       
        }

        public int  arraycharindex(char[] arraychar, char targetchar)
        {
            int start=0;
            int end=arraychar.Length;
      
                
                    while(start<=end)        
                        {
                            int mid=(start+end)/2;
                            if(arraychar[mid]==targetchar)
                            {
                                return mid;
                                
                            }
                            else  if(arraychar[mid]>targetchar)
                            {
                                end=mid-1;
                                
                            
                            }
                            else if(arraychar[mid]<targetchar)
                            {
                                start=mid+1;
                           
                            
                            }
                
                        }
                        return  -1;
                
       
        }
    public int  arraystringindex(string[] arraystring, string targetstring)
        {
            int start=0;
            int end=arraystring.Length;
      
                
                    while(start<=end)        
                        {
                            int mid=(start+end)/2;
                            if(string.Compare(arraystring[mid],targetstring)==0)
                            {
                                return mid;
                                
                            }
                            else  if(string.Compare(arraystring[mid],targetstring)>0)
                            {
                                end=mid-1;
                                
                            
                            }
                            else if(string.Compare(arraystring[mid],targetstring)<0)
                            {
                                start=mid+1;
                           
                            
                            }
                
                        }
                        return  -1 ;
                
       
        }

    }
}
