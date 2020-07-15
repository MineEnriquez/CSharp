using System;

namespace PerfectShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "aaaaaaaa";
            string b = "1234567890";
            Console.WriteLine(perfectshuffle(a, b));
        }

        static string perfectshuffle(string s, string t)
        {
            int n = s.Length/2;
            int m = t.Length/2;

            Console.WriteLine(s);
            Console.WriteLine (n);

            Console.WriteLine(t);         
            Console.WriteLine (m);

            if (s.Length <= 1 || t.Length<=1) return s + t;

            string a = perfectshuffle(s.Substring(0, n), t.Substring(0, m));
            string b = perfectshuffle(s.Substring(n, s.Length - n), t.Substring(m, t.Length - m));
            return a + b;
        }
    }
}
