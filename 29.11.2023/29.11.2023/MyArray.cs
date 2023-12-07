

using System.Collections.Generic;

namespace Myspace
{
    internal class MyArray : ISort, IMath, IOutput
    {
        private List<int> array;

        public MyArray()
        {
            array = new List<int>();
        }

        public void Add(int i)
        {
            array.Add(i);
        }
        public int Max()
        {
            int max = Int32.MinValue;

            for(int i = 0; i < array.Count; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        public int Min()
        {
            int min = Int32.MaxValue;

            for(int i = 0; i < array.Count; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        public float Avg()
        {
            int avg = 0;
            

            foreach(int a in array)
            {
                avg += a;

            }
            return avg / array.Count;
        }
        public bool Search(int valueToSearch)
        {
            foreach (int a in array)
            {
                if (a == valueToSearch)
                {
                    return true; 
                }
            }
            return false;
        }

        public void Show()
        {
            foreach(int a in array)
            {
                Console.Write(a + " ");
            }
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
        }

        public void SortAsc() {
            array.Sort();

        }

        public void SortDesc()
        {
            array.Sort((a,b) => b.CompareTo(a));
        }
    }
}
