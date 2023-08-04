using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_console
{
    public class Arr
    {
        private int idx;
        private double[] array;
        
        public Arr(int length) =>
            array = new double[length];

        public void Insert(double n)
        {
            if (array.Length == idx)
            {
                double[] arr = new double[array.Length + 1];
                array.CopyTo(arr, 0);
                arr[arr.Length - 1] = n;
                array = arr;
            }
            array[idx++] = n;
        }

        public int GetIndex(double n)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == n) return i;
            return -1;
        }

        public void Remove()
        {
            double[] arr = new double[idx--];
            for (int i = 0; i < idx; i++)
                arr[i] = array[i];
            array = arr;
        }

        public void RemoveAt(int index)
        {
            if (index >= array.Length || index < 0)
                throw new Exception("Index out of range");

            int n = 0;
            double[] arr = new double[--idx];
            for (int i = 0; i <= idx; i++)
            {
                if (i == index) continue;
                arr[n++] = array[i];
            }
            array = arr;
        }

        public void Max()
        {
            double m = array[0];
            foreach (double n in array)           
                if (m < n) m = n;
            return m;
        }

        public void Intersect(double[] arr)
        {
            double[] copies = new double[array.Length];
            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (array[j] == arr[i])
                        copies[i] = array[j];
                }
            }
        }

        public void Reverse()
        {
            double[] reversed = new double[array.Length];
            int idx = array.Length - 1;
            for (int i = array.Length - 1; i >= 0; i--)
                reversed[idx - i] = array[i];
            array = reversed;
        }

        public void InsertAt(int index, double n)
        {
            double[] arr = new double[array.Length + 1];
            array.CopyTo(arr, 0);
            for (int i = arr.Length - 1; i > index; i--)
                arr[i] = arr[i - 1];
            arr[index] = n;
            array = arr;
        }

        public void Print()
        {
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
    }
}
