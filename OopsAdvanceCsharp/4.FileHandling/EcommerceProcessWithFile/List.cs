using System;


namespace EcommerceProcess
{
    public partial class List<Type>
    {
        private Type[] Array {get;set;}//Array declaration
        private int _count;
        private int _capacity;
        public int Count {get{return  _count;}}
        public int Capacity { get {return _capacity;}}


        public Type this[int i]
        {
            get{{return Array[i];}}
            set{{Array[i]=value;}}
        }

        public List()
        {
            _count=0;
            _capacity=4;
            Array= new Type[_capacity];
        }

        public List(int size)
        {
            _count=0;
            _capacity=size;
            Array= new Type[_capacity];
        }

        public void Add(Type value)
        {

              if(_count==_capacity)
              {
                 GrowSize();
              }
               Array[_count]=value;
               _count++;
        }

        public void GrowSize()
        {
            _capacity=_capacity*2;
            Type[] ArrayMax= new Type[_capacity];
            for(int i=0; i<Array.Length; i++)
            {
                ArrayMax[i]=Array[i];
            }
            Array=ArrayMax;

        }
    }
}