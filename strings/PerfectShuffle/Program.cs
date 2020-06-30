using System;

namespace PerfectShuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "aaaaaa";
            string b = "bbbbbb";
            Console.WriteLine(perfectshuffle(a, b));
        }

        static string perfectshuffle(string s, string t)
        {
            //BUG: it doesn't finish the sequence.
            if (s.Length != t.Length) return "I can't shuffle it";
            int n = s.Length;

            if (n <= 1) return s + t;

            string a = perfectshuffle(s.Substring(0, s.Length / 2), t.Substring(0, t.Length / 2));
            string b = perfectshuffle(s.Substring(s.Length / 2 + s.Length % 2, s.Length - (s.Length / 2 + s.Length % 2)), t.Substring(t.Length / 2 + t.Length % 2, t.Length - (t.Length / 2 + t.Length % 2)));
            return a + b;
        }
    }
}
