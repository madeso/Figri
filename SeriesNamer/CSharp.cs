using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeriesNamer
{
    public static class CSharp
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static IEnumerable<T> Enumerate<T>(params T[] args)
        {
            foreach (T a in args)
            {
                yield return a;
            }
        }

        public static bool IsEmpty<T>(IEnumerable<T> e)
        {
            foreach (T a in e)
            {
                return false;
            }
            return true;
        }
    }
}
