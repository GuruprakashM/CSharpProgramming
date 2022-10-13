using System;


namespace AdmissionProcess
{
    public partial class List<Type>
    {
         private Type[] Array{get;set;}//array

         private int _capacity;//field
         private int _count;//field
         public int Capacity{get{return _capacity;} }//Property
         public int Count {get{return _count;}}//property
         
         public Type this[int i]
         {
            get{return Array[i];}
            set{Array[i]=value;}
         }
         public List()//this is the starting values of both count and capacity// initialisation
         {
            _count=0;
            _capacity=4;
            Array = new Type[_capacity];

         }
         public List(int size)
         {
            _count=0;
            _capacity=size;
            Array = new Type[_capacity];
         }
         public void AddElement(Type data)
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
             Type[] ArrayMax= new Type[_capacity];// int[] a= new int[10];

             for (var i=0; i<Array.Length; i++)
             {
                ArrayMax[i]=Array[i];
             }
            Array=ArrayMax;
         }

         

         
    }
}