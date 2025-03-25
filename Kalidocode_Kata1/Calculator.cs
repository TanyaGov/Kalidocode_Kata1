using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalidocode_Kata1
{
    class Calculator
    {
        public static string errorMessage = "";

        public int Add(string? input)
        {
            List<int> numbers = new List<int>();
            int length = input.Length; int sum = 0;

            if (string.IsNullOrEmpty(input) || input.Contains(" ")) { return 0; } // null input >> automatically sum = 0
            if (input.Contains(",,") || input.Contains(",\\n") || input.Contains("\\n,")) { throw new Exception("Incorrect format of numbers"); }

            try { sum = int.Parse(input); return sum; } catch { return -1; }
           
        }
    }
}
