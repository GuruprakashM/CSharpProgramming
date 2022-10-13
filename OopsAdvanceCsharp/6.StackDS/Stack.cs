using System;


namespace StackDS
{
    public class Stack<Type>
    {
        private Type[] Array {get; set;}
        public int _count;
        public int Count { get{return _count;} }
        public int _capacity;
        public int Capacity { get{return _capacity;} }
        
        public Stack()
        {
            _count=0;
            _capacity=0;
            Array= new Type[_capacity];
            

        }

        public Stack(int size)
        {
             _count=0;
             _capacity=size;
             Array= new Type[_capacity];
        }
        public void Push(Type data)
        {
           if(_count==_capacity)
           {
              GrowSize();
           }
           Array[_count]=data;
           _count++;
        }
       public void GrowSize()
       {
             _capacity=_capacity*2;
             Type[] Arraynew = new Type[_capacity];
             for (int i=0; i<Array.Length; i++)
             {
                Arraynew[i]=Array[i];
             }
           Array=Arraynew;
       }
       public Type Pop()
       {
            Type value = default(Type);
             if(_count<0)
             {
                Console.WriteLine($"Empty Stack");
                
                
             }       
             else if(_count>=0)
             {
               value=Array[_count];
               _count--;
             }
           return value;
       }
       public bool Contains(Type data)
       {
          bool value=false;
          foreach( var i in Array)
          {
            if (i.Equals(data))
            {
               value=true;
            }
             
          }
           return value;
       }

       public Type peek()
       {
        
        return Array[_count-1];
       }

    }
}