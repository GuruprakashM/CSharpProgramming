using System;
using System.Collections;

namespace EcommerceProcess
{
    public partial class List<Type>
    {
        public void Insert(int index, Type value)
        {
            Type[] Arrayupdate = new Type[_capacity+1];
            int Count=0;
             for( int i=0 ; i<Array.Length-1; i++)
             {
                if(i==index)
                {
                    Count++;
                    Arrayupdate[i]=value;
                }
                else if(Count>0)
                {
                    Arrayupdate[i]=Array[i-1];
                }
                else 
                {
                    Arrayupdate[i]= Array[i];
                }
             }
             Array=Arrayupdate;
             _count++;
        }


        public void RemoveAt(int index)
        {
           for( int i=0; i<Array.Length-1; i++)

           {
              if (i>=index)
              {
                Array[i]=Array[i+1];
              }
           }
           _count--;
           
        }

        public void Remove(Type value)
        {
            int index=0;
            for(int i=0 ; i<Array.Length-1; i++)
            {
                if(Array[i].Equals(value))
                {
                    index=i;
                }
            }
            for(int i=0; i<Array.Length-1; i++)
            {
                if(i>=index)
                {
                    Array[i]=Array[i+1];
                }
            }
            _count--;
        }
    }
}