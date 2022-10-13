using System;
using System.Collections;

namespace AdmissionProcess
{
    public partial class List<Type>:IEnumerable,IEnumerator
    {
        private int i;
        public IEnumerator GetEnumerator()//I Enumberable Inferface return typr I Enumerator it has 2 methods and 1 property
        {
            i =-1;
            return (IEnumerator) this;
        }
        public bool MoveNext()
        {
            if(i<_count-1)
            {
                ++i;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            i=-1;

        }
        public object Current 
        {
            get {return Array[i];}
        }
    }
}