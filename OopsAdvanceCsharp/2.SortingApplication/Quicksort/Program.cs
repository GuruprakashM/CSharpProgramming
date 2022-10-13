 using System;

namespace Quicksort {
   class Program {
      
  
      static void Main(string[] args)
        {
         int[] arr = {23,45,67,78,9,92,3,1,44,66}; 
         int n = 10, i;   
         Console.WriteLine("Quick Sort");
         Console.Write("Initial array is: ");   
         for (i = 0; i < n; i++)
        {
            Console.Write($"{arr[i]} ");
         }
         quickSort(arr, 0, 9); //starting index=0, last index=9
         Console.Write("\nSorted Array is: ");   
         for (i = 0; i < n; i++) {
            Console.Write($" {arr[i] }"); 
         }
      }
      static public int Partition(int[] arr, int left, int right)
       {
                            int target; 
                            target = arr[left];
                            while (true) {
                                while (arr[left] < target) {
                                left++;
                                }    
                                while (arr[right] > target) {
                                right--;
                                }    
                                if (left < right) {
                                int temp = arr[right];
                                arr[right] = arr[left];
                                arr[left] = temp;
                                } else {
                                return right;
                                }
         }

      }
          static public void quickSort(int[] arr, int left, int right) 
          {   
                        int target;   
                        if (left < right) {
                            target = Partition(arr, left, right);
                            if (target > 1) {
                            quickSort(arr, left, target - 1);
                            }
                            if (target + 1 < right) {
                            quickSort(arr, target + 1, right);
                            }
                        }
         }
   }
}
     
