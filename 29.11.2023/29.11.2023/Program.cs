using System;

namespace Myspace{
    class Program
{
        public static void Main(string[] args)
        {
            MyArray array = new MyArray();

            array.Add(3);
            array.Add(1);
            array.Add(3);
            array.Add(9);
            array.Add(5);
            array.Add(8);
            array.Add(7);



            array.Show("Unsorted array");
            array.Show();
            Console.WriteLine();

            array.SortDesc();
            Console.WriteLine();
            array.Show("Sorted desc array");
            array.Show();
            Console.WriteLine();

            array.SortAsc();
            Console.WriteLine();
            array.Show("Sorted asc array");
            array.Show();
            Console.WriteLine();
            Console.WriteLine();

            array.Show($"Min: {array.Min()}");
            array.Show($"Max: {array.Max()}");
            Console.WriteLine();

            array.Show($"Avarage num: { array.Avg()}");
            Console.WriteLine();

            if (array.Search(4) == true)
            {
                Console.WriteLine("this num is in array");
            }
            else
            {
                Console.WriteLine("this num is not in array");
            }
        }
}
}
