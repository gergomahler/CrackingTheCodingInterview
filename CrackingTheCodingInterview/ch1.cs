using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{
    class ch1
    {
            // 1.1 IsUnique

            public bool IsUnique(string str)
            {
                HashSet<char> charSet = new HashSet<char>();
                foreach (char c in str)
                {
                    charSet.Add(c);
                }
                return charSet.Count == str.Length;
            }

    }
}
