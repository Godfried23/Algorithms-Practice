using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int theValue = 43;
            int[] array = new int[] {11, 22, 43, 54, 57, 59, 62, 78 };

            WriteLine("Our array contains: ");
            Array.ForEach(array, x => Write(x + " "));

            Write($"\n\nThe result of a binary search for {theValue} is: ");
            var watch = System.Diagnostics.Stopwatch.StartNew();//timing
            WriteLine(BinarySearch(array, theValue));
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            WriteLine("Elapsed time: {0}ms: ", elapsedMs);

            ReadLine();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">array</param>
        /// <param name="x">what we're searching for</param>
        /// <param name="p">first index</param>
        /// <param name="q">midpoint</param>
        /// <param name="r">last index</param>
        /// <returns></returns>
        public static int BinarySearch(int[] a, int x)
        {
            int p = 0;
            int r = a.Length - 1;

            while (p <= r)
            {
                int q = (p + r) / 2;

                if (x < a[q])
                    r = q - 1;
                else if (x > a[q])
                    p = q + 1;
                else return q;
            }
            return -1;
        }
    }
}
