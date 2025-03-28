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
            { sum = 0; }
            else if (input.Contains(","))
            {
                string[] arrNumbers = input.Split(',');
                foreach (string number in arrNumbers)
                {
                    sum += Convert.ToInt32(number);
                }

            }

            else { sum = Convert.ToInt32(input); }
            return sum;
        }

    }
}
