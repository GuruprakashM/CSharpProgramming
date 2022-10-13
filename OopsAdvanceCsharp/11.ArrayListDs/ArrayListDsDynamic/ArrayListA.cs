using System;
using System.Collections;


namespace ArrayListDS
{
    public partial class ArrayList
    {
        public void Insert(int index, dynamic datas)
        {
         dynamic[] Arrayupdate= new dynamic[_capacity+1];
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
          _count++;
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
      public void remove (dynamic value)
      {
          int count=0;
          for(int i =0; i<Array.Length-1; i++)
          { 
               if(value.Equals(Array[i]))//find index
               {
                count=i;
               }
          }
           for(var i=0; i<Array.Length-1; i++)// same sa remove at
            {
                if(i>=count)
                {
                   Array[i]=Array[i+1];
                }
               
            }
            _count--;

      }


     
    }
}