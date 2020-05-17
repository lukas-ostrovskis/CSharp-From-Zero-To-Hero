using System;
//using Console = System.Console;


namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {
        

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Sort the array in ascending order.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        /// 

        public static void Sort(int[] array)
        {
            if (array == null) return;

            for(int i = 0; i < array.Length-1; i++)
            {
                for(int j = i+1; j < array.Length; j++)
                {
                    if (array[i] > array[j]) Swap(ref array[i], ref array[j]);      
                }
            }
        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            if (array == null) return;

            for(int i = 0; i < array.Length / 2; i++)
            {
                Swap(ref array[i], ref array[(array.Length - 1) - i]);
            }
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            if (array == null || array.Length == 0) return array;

            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < array.Length - 1; i++) newArray[i] = array[i];

            return newArray;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            if (array == null || array.Length == 0) return array;

            int[] newArray = new int[array.Length - 1];

            for (int i = 1; i < array.Length; i++) newArray[i - 1] = array[i];

            return newArray;
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            if (array == null || array.Length == 0 || index < 0 || index >= array.Length) return array;

            int shift = 0;
            int[] newArray = new int[array.Length - 1];

            for(int i = 0; i < array.Length-1; i++)
            {
                if (i == index) shift = 1;
                newArray[i] = array[i + shift];
            }

            return newArray;
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            if(array == null)
            {
                int[] _newArray = new int[] { number };
                return _newArray;
            }

            int[] newArray = new int[array.Length + 1];
            newArray[0] = number;

            for (int i = 0; i < array.Length; i++) newArray[i + 1] = array[i];

            return newArray;
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            if (array == null)
            {
                int[] _newArray = new int[] { number };
                return _newArray;
            }

            int[] newArray = new int[array.Length + 1];
            newArray[^1] = number;

            for (int i = 0; i < array.Length; i++) newArray[i] = array[i];
            
            return newArray;
        }

        /// <summary>
        /// Inserts a new array element at the specified index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <param name="index">Index at which array element should be added.</param>
        /// <returns>A new array with element inserted at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertAt(int[] array, int number, int index)
        {
            if (index < 0 || (array != null && index > array.Length)) return array;

            if (array == null || array.Length == 0)
            {
                int[] _newArray = new int[] { number };
                return _newArray;
            }
            

            int[] newArray = new int[array.Length + 1];
            int shift = 0;
            newArray[index] = number;


            for(int i = 0; i < newArray.Length; i++)
            {
                if (i == index) {
                    shift = -1;
                    continue;
                }

                newArray[i] = array[i + shift];
            }

            return newArray;
        }
    }
}
