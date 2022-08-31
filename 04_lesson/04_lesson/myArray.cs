using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_lesson
{
    internal class MyArray
    {

        private int[] array;

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

        public MyArray(int[] array)
        {
            this.array = array;
        }

        public MyArray(int size)
        {
            Random random = new Random();
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-99, 100);
            }
        }

        public MyArray(int size, int firstElement, int step)
        {
            array = new int[size];
            array[0] = firstElement;
            for (int i = 1; i < size; i++)
            {
                array[i] = array[i - 1] + step;
            }
        }

        public MyArray(string fileName)
        {
            array = LoadArrayFromFile(fileName);
        }
        public int Max // Находим максимальный элемент
        {
            get
            {  
                int max = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max) max = array[i];
                }
                return max;
            }
        }
        public int Min
        {
            get
            {
                // Находим минимальный элемент
                int min = array[0];
                for (int i = 1; i < array.Length; i++)
                    if (array[i] < min) min = array[i];
                return min;
            }
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                    sum += array[i];
                return sum;
            }
        }

        public int MaxCount
        {
            get
            {
                int max = Max;
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == max) count++;
                return count;
            }
        }

        public MyArray Inverse()
        {
            MyArray inversedArray = new MyArray(array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                inversedArray[i] = array[i] * -1;
            }
            return inversedArray;
        }

        public void Multi(int multiplicator)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * multiplicator;
            }
            
        }

        public void PrintArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
            }
            Console.WriteLine();
        }

        private int[] LoadArrayFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                //StreamWriter
                //    WriteLine
                StreamReader streamReader = new StreamReader(fileName);
                int[] buf = new int[1000];
                int count = 0;
                //streamReader.ReadLine();
                //streamReader.EndOfStream
                while (!streamReader.EndOfStream)
                {
                    buf[count] = int.Parse(streamReader.ReadLine());
                    count++;
                }

                int[] arr = new int[count];
                Array.Copy(buf, arr, count);
                streamReader.Close();
                return arr;

            }
            else
                throw new FileNotFoundException();
        }


    }

    
}
