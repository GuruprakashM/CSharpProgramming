using System;
namespace MergeSort
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int[] array={1,3,6,7,89,30,23,24};
            int left=0;
            int right=array.Length-1;
             SortArray( array,left,right);
            void SortArray(int[] array, int left, int right)
            {
                
                            if (left < right)
                            {
                                int middle = (right +left) / 2;

                                SortArray(array, left, middle);
                                SortArray(array, middle + 1, right);

                                MergeArray(array, left, middle, right);
                            }

                            
                 
             }

         void MergeArray(int[] array, int left, int middle, int right)
            {
                int leftArrayLength = middle - left + 1;
               int rightArrayLength = right - middle;
                int[] leftTempArray = new int[leftArrayLength];
                int[] rightTempArray = new int[rightArrayLength];
                int i, j;

                for (i = 0; i < leftArrayLength; ++i)
                    leftTempArray[i] = array[left + i];
                for (j = 0; j < rightArrayLength; ++j)
                    rightTempArray[j] = array[middle + 1 + j];

                i = 0;
                j = 0;
                int k = left;

                while (i < leftArrayLength && j < rightArrayLength)
                {
                    if (leftTempArray[i] <= rightTempArray[j])
                    {
                    array[k++] = leftTempArray[i++];
                    }
                    else
                    {
                    array[k++] = rightTempArray[j++];
                    }
                }

                while (i < leftArrayLength)
                {
                    array[k++] = leftTempArray[i++];
                }

                while (j < rightArrayLength)
                {
                    array[k++] = rightTempArray[j++];
                }
         }
          
        Console.WriteLine($"After sorting the Array");
        foreach( int output in array)
        {
            Console.Write($"{output}");
            
        }
        
          
    }

  
    
}
}