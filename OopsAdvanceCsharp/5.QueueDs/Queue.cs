using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueueDs
{
    public class Queue<Type>
    {
        private Type[] Array{get; set;}
        private int _count;
        public int Count {get{return _count;}}

        private int _head;
        public int Head {get{return _head;}}

       private int _capacity;
        public int Capacity {get{return _capacity;}}

        private int _tail;
        public int Tail {get{return _tail;}}

    public Queue ()
    {
        _count=0;
        _head=0;
        _capacity=4;
        _tail=0;
        Array= new Type[_capacity];

    }
    public Queue(int size)
    {
        _count=0;
        _head=0;
        _capacity=size;
        _tail=0;
         Array = new Type[_capacity];
    }

    public void Enqueue(Type data)
    {
        if(_count==_capacity)
        {
             GrowSize();
        }
        Array[_tail]=data;
        _tail++;
        _count++;
    }
    public void GrowSize()
    {
        _capacity=_capacity*2;
        Type[] ArrayNew= new Type[_capacity];
        for(int i=0; i<_tail; i++)
        {
            ArrayNew[i]=Array[i];

        }
        ArrayNew=Array;
    }

    public Type Dequeue ()
    {
        Type value = default(Type);

        if(_head>_tail)
        {
           Console.WriteLine($"Queue is Empty");
           
        }
        else 
        {
            value= Array[_head];
            _head++;
            _count--;
        }
        return  value;

    }
    

    public Type Peek ()
    {
       Type value =default (Type);
       if(_head>_tail)
       {
          Console.WriteLine("Queue is Empty");
       }
       else 
       {
        value=Array[_head];
       }
       return value;
    }
    public bool Contains(Type datas)
    {
          bool value=false;
          foreach( var i in Array)
          {
            if(i.Equals(datas))
            {
              value =true;
            }
          }
          return value;
    }
    }
}