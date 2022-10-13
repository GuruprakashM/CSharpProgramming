using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionProcess
{
    public partial class List<Type>
    {
        public void Insert(int index, Type datas)
        {
         Type[] Arrayupdate= new Type[_capacity+1];
         int count=0;
          for(var i=0; i<Array.Length; i++)
          {
             
             if(i==index)
             {
        
                count++;
                Arrayupdate[i]=datas;
              
             }
             else if(count>0)
             {
                Arrayupdate[i]=Array[i-1];
             }
             else
             {
                Arrayupdate[i]=Array[i];
             }
             
          }
         Array=Arrayupdate;
        
        }
    
       public void removeAt(int index)
       {
            for(var i=0; i<Array.Length-1; i++)
            {
                if(i>=index)
                {
                   Array[i]=Array[i+1];
                }
               
            }
              _count--;
     
       }
      public void remove (Type value)
      {
          int count=0;
          for(int i =0; i<Array.Length-1; i++)
          { 
               if(value.Equals(Array[i]))
               {
                count=i;
               }
          }
           for(var i=0; i<Array.Length-1; i++)
            {
                if(i>=Count)
                {
                   Array[i]=Array[i+1];
                }
               
            }
            _count--;

      }


     
    }
}