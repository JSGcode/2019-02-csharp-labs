using System;

namespace Lab_04_array
{
    public class Array
    {
        public int CreateArray(int size)
        {
            int[] myArray = new int[size];
            //insert squares 
            for (int i=0; i < size; i++)
            {
                myArray[i] = i * i;
            }

            int total = 0;
            for (int i = 0; i < size; i++)
            {
                total += myArray[i];
            }
            return total;
        }
    }
}
