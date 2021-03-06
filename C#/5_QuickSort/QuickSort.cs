using System;

namespace Algorithm {

    class QuickSort {
        
        public static void quickSort(int[] arr, int left, int right) {
            int l = left;
            int r = right - 1;
            int size = right - left;

            if(size > 1){
                Random rn = new Random();
                int pivot = arr[rn.Next(size) + l];

                while (l < r) {
                    while(arr[r] > pivot && r > l) {
                        r--;
                    }

                    while(arr[l] < pivot && l <= r) {
                        l++;
                    }

                    if(l < r) {
                        int temp = arr[l];
                        arr[l] = arr[r];
                        arr[r] = temp;
                    }
                }
                quickSort(arr, left, l);
                quickSort(arr, r, right);
            }
        }

        public static void printArray(int[] arr) {
            for(int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i] + " ");
            }
        }

        public static void Main(string[] args){
            int[] arr = { 10, 54, 63, 6, 420, 11, 41, 32, 17, 22 };
            quickSort(arr, 0, arr.Length);
            printArray(arr);
        }
    }
}