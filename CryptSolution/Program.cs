using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] crypt = { "WASD",
 "IJKL",
 "AOPAS" };    // { "SEND", "MORE", "MONEY" };
            char[][] solution = new char[][] {
                new char[] { 'W', '2' },
                new char[] { 'A', '0' },
                new char[] { 'S','4' },
                new char[] { 'D', '1' },
                new char[] { 'I', '5' },
                new char[] { 'J', '8' },
                new char[] { 'K', '6' },
                new char[] { 'L', '3' },
                new char[] { 'O', '7' },
                new char[] { 'P', '9' },

            };

            //char[][] solution = new char[][]
            //{
            //    new char[] {'O','1'},
            //    new char[] {'T','0'},
            //    new char[] {'W','9'},
            //    new char[] {'E','5'},
            //    new char[] {'N','4'},
            //};
         //   char[][] solution = new char[][]
         //{
         //       new char[] {'A','1'},
         //       new char[] {'B','0'},
         //       new char[] {'C','2'},
         //};

            bool isCrypt = isCryptSolution(crypt, solution);
            Console.ReadKey();
        }

        private static bool isCryptSolution(string[] crypt, char[][] solution)
        {
            StringBuilder word1 = new StringBuilder();
            StringBuilder word2 = new StringBuilder();
            StringBuilder word3 = new StringBuilder();
            for (int i = 0; i < crypt.Length; i++)
            {
                if (i == 0)
                {
                    foreach (var item in crypt[i])
                    {
                        char[] a = solution.First(x => x[0] == item).ToArray();
                        word1.Append((a[1].ToString()));
                    }
                }
                else if (i == 1)
                {
                    foreach (var item in crypt[i])
                    {
                        char[] a = solution.First(x => x[0] == item).ToArray();
                        word2.Append(a[1].ToString());
                    }
                }
                else
                {
                    foreach (var item in crypt[i])
                    {
                        char[] a = solution.First(x => x[0] == item).ToArray();
                        word3.Append(a[1].ToString());
                    }
                }
            }
            if ((word1.Length > 1 && word2.Length > 1 && word3.Length > 1) && (word1.ToString().ElementAtOrDefault(0) == '0' || word2.ToString().ElementAtOrDefault(0) == '0' || word3.ToString().ElementAtOrDefault(0) == '0'))
            {
                return false;
            }
            return Convert.ToInt64(word1.ToString()) + Convert.ToInt64(word2.ToString()) == Convert.ToInt64(word3.ToString());
        }
    }
}
