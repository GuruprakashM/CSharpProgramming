using System;
using System.Collections;


namespace MovieBooking
{
    public partial class List<Type>:IEnumerable,IEnumerator
    {
        /// <summary>
        /// Count the number of Elements
        /// </summary>
        private int i;
        /// <summary>
        /// Support Iteration process for the List
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            i=-1;
            return (IEnumerator) this;
        }
        /// <summary>
        /// Making the Process of moving next into iteration
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            if(i<_count-1)
            {
                i++;
                return true;
            }
            Reset();
            return false;

        }
        /// <summary>
        /// Reset the count
        /// </summary>
        public void Reset()
        {
            i=-1;
        }
        /// <summary>
        /// Returns the value to the list
        /// </summary>
        /// <value></value>
        public object Current
        {
            get {return Array[i];}
        }
    }
}