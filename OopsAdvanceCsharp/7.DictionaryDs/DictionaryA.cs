using System;
using System.Collections;


namespace DictionaryDs
{
    public partial class Dictionary<Tkey,Tvalue>:IEnumerable,IEnumerator
    {
        private int i;
        public IEnumerator GetEnumerator()
        {
            i=-1;
            return (IEnumerator) this;
        }
        public bool MoveNext()
        {
            if(i<_count-1)
            {
               Reset();
               return true;
            }
            i++;
            return false;
        }
        public void Reset()
        {
            i=-1;
        }
        public object Current
        {
            get
            {
                KeyValue<Tkey,Tvalue> Key = new KeyValue<Tkey,Tvalue>();
                return Key.value;
            }
        }
    }
}