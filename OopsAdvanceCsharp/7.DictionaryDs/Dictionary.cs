using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryDs
{
   public partial class Dictionary<Tkey, Tvalue>
    {
        
        private KeyValue<Tkey,Tvalue> []Array{get; set;}
        private int _count;
        public int Count { get{return _count;}}
        private int _capacity;
        public int Capacity { get{return _capacity;}}
        public Dictionary()
        {
            _count=0;
            _capacity=4;
            Array = new KeyValue<Tkey, Tvalue>[_capacity];

        }
        public Dictionary(int size)
        {
           if(size==0)
           {
            _capacity=size;
            _count=0;
            Array = new KeyValue<Tkey, Tvalue>[_capacity];

           }
           else if(size>0)
           {
            _capacity=_capacity*2;
            _count=0;
            Array = new KeyValue<Tkey, Tvalue>[_capacity];
            
           }


        }
        public void Add(Tkey key,Tvalue value)
        {
            if(_capacity==_count)
            {
                GrowSize();
            }
            bool temp =LinearSearch(key,out int index);
           
            if(temp==true)
            {
               Console.WriteLine($"Duplicate key");
               
            }
            if(temp==false)
            {
            KeyValue<Tkey,Tvalue> entry = new KeyValue<Tkey, Tvalue>();
            entry.key=key;
            entry.value=value;
            Array[_count]=entry;
            _count++;
            }


        }
        public void GrowSize()
        {
            _capacity=_capacity*2;
            KeyValue<Tkey,Tvalue>[] ArrayUpdate = new  KeyValue<Tkey,Tvalue>[_capacity];
            
            for(int i=0; i<Array.Length-1; i++)
            {
                ArrayUpdate[i]=Array[i];
            }
          Array=ArrayUpdate;
        }

      public void Display()
      {
        foreach (KeyValue<Tkey, Tvalue> element in Array)
        {
            if(element!=null)
            {
                Console.WriteLine($"key : {element.key} value :{element.value}");
                
            }
        }
      }

      public bool LinearSearch(Tkey key,out int index)
      {
          bool condition=false;
          index=0;
          for(int i=0; i<_count; i++)
          {
            if(Array[i].key.Equals(key))
            {
              condition=true;
              index=i;
              break;
            }
          }
          return condition;
      }
      public Tvalue this[Tkey key]
      {
          get
          {
            Tvalue output = default (Tvalue);
            int index=0;
            bool temp =LinearSearch(key,out index);
            if(temp)
            {
               output =Array[index].value;
            }
            else 
            {
              Console.WriteLine($"Invalid Key");
              
            }
            return output;
          }

          set //here Set is the Update purpose //values are modified by keys
          {
            int position=0;
            bool temp=LinearSearch(key,out position);
            if(temp)
            {
              Array[position].value=value;
            }
            else 
            {
              Console.WriteLine($"Invalid Key");
              
            }
          }
      }
          public bool Containskey(Tkey key)
          {
          bool condition=false;
      
          for(int i=0; i<_count; i++)
          {
            if(Array[i].key.Equals(key))
            {
              condition=true;
              
              
            }
          }
          return condition;
          }
          public bool ContainsValue(Tvalue value)
          {
            bool condition =false;
            for(int i=0; i<_count; i++)
            {
                 if(Array[i].value.Equals(value))
                 {
                  condition=true;
                 }
            }
            return condition;
          }

          public KeyValue<Tkey,Tvalue> ElementAt(int index)
          {

            KeyValue<Tkey,Tvalue> output=null;
            
              for(int i=0; i<_count; i++)
              {
                if(i<=index)
                {
                   output=Array[index];
                }
              
              }
             
            return output;
          }


          public bool Remove(Tkey key)
          {
             KeyValue<Tkey,Tvalue>[] ArrayUpdate = new KeyValue<Tkey,Tvalue>[_capacity+1];
             int index=0;
             bool condition=false;
             for( int i=0; i<Count; i++)
             {
                if(Array[i].key.Equals(key))
                {
                  index=i;
                }
             }
             for(int i=0 ; i<Count; i++)
             {
                if(index>=i)
                {
                  ArrayUpdate[i]=Array[i+1];
                  condition=true;
                }
             }
             Array=ArrayUpdate;
             _count--;
               
            return condition;
          }
      }
    }
