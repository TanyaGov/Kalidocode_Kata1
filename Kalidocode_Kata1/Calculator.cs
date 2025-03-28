using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalidocode_Kata1
{
    public class Calculator
    {
        public int Add(string input)
        {
            int sum = 0;

            if (string.IsNullOrEmpty(input) || input == " ")
            { return 0; }

            if (input.Contains("//"))
            {
                int indexAfterSlash = input.LastIndexOf("/") + 1;
                int indexNextLine = input.IndexOf("\n");

                string delimiters = input.Substring(indexAfterSlash, indexNextLine - indexAfterSlash);
                string numbers = input.Substring(indexNextLine + 1);

                if (delimiters.Contains("[") && delimiters.Contains("]"))
                {
                    string[] arrDelimiters = delimiters.Split(new string[] { "[", "]" }, StringSplitOptions.RemoveEmptyEntries);
                    string[] arrNumbers = numbers.Split(arrDelimiters, StringSplitOptions.RemoveEmptyEntries);
                    return GetSum(arrNumbers);
                }

                else
                {
                    string[] arrNumbers = numbers.Split(delimiters);
                    return GetSum(arrNumbers);
                }
            }

            if (input.Contains(",") || input.Contains("\n"))
            {
                string[] arrNumbers = input.Split(new string[] { ",", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                return GetSum(arrNumbers);
            }

            return Convert.ToInt32(input);

        }

        public int GetSum(string[] arrNumbers)
        {
            int sum = 0;
            string negatives = "";

            foreach (string number in arrNumbers)
            {
                int num = Convert.ToInt32(number);

                if (num >= 0 && num < 1000)
                { sum += num; }

                else if (num < 0)
                { negatives += num + "\t"; }
            }

            if (negatives.Length > 0)
            { throw new Exception("Negative numbers found:" + negatives); }

            return sum;
        }

    }
}
