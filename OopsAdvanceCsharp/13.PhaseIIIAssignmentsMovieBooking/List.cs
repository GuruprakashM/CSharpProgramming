using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieBooking
{
    public partial class List<Type>
    {
        /// <summary>
        /// ARRAY INITIALAISATION
        /// </summary>
        /// <value></value>
        private Type[] Array {get;set;}
        /// <summary>
        /// COUNT OF ARRRAY ELEMENTS
        /// </summary>
        private int _count;
        /// <summary>
        /// CAPACITY OF ARRAY
        /// </summary>
        private int _capacity;
        // <summary>
        /// COUNT OF ARRRAY ELEMENTS
        /// </summary>

        public int Count { get; set; }
          /// <summary>
        /// CAPACITY OF ARRAY
        /// </summary>
        public int Capacity{get; set;}
        
        public Type this [int  i]
        {
            get {return Array[i];}
            set {Array[i]= value;}
        }
        /// <summary>
        ///  DEFAULT CONSTRUCTOR FOR THR LIST 
        /// </summary>
        public List()
        {
            _count=0;
            _capacity=4;
            Array= new Type[_capacity];


        }

        /// <summary>
        /// CONSTRUCTOR FOR THE LIST
        /// </summary>
        /// <param name="size"></param>

        public List(int size)
        {
           _count=0;
           _capacity=size;
           Array= new Type[_capacity];
        }
        /// <summary>
        /// LIST Add ELEMENT process
        /// </summary>
        /// <param name="value"></param>
        public void Add(Type value)
        {
            if(_count==_capacity)
            {
              GrowSize();
            }
            Array[_count]=value;
            _count++;
        }
        /// <summary>
        /// List Grow size Process
        /// </summary>
        public void GrowSize()
        {
            _capacity=_capacity*2;
            Type[] ArrayMax = new Type[_capacity];
            for( int i=0; i<_count; i++)
            {
                ArrayMax[i]= Array[i];
            }
            Array=ArrayMax;
        }
    }
}