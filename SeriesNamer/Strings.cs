using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeriesNamer
{
    public static class Strings
    {
        public static IEnumerable<string> sort(IEnumerable<string> strings)
        {
            List<string> str = new List<string>();
            str.AddRange(strings);
            str.Sort();
            return str;
        }
        public static IEnumerable<string> unique(IEnumerable<string> strings)
        {
            SortedList<string, string> list = new SortedList<string, string>();
            foreach (string s in strings)
            {
                if (list.ContainsKey(s) == false)
                {
                    list.Add(s, s);
                }
            }
            foreach (KeyValuePair<string, string> s in list)
            {
                yield return s.Key;
            }
        }
        public static string FirstChars(string s, int count, string extra)
        {
            int l = s.Length;
            if (s.Length + extra.Length > count) return s.Substring(0, count - extra.Length) + extra;
            else return s;
        }
        public static string FirstChars(string s, int count)
        {
            return FirstChars(s, count, "...");
        }

        public static IEnumerable<string> Enumerate(params string[] args)
        {
            return CSharp.Enumerate<string>(args);
        }

        public static string Combine(string a, params string[] b)
        {
            string r = a;
            foreach (string s in b)
            {
                r = System.IO.Path.Combine(r, s);
            }
            return r;
        }
    }
}
