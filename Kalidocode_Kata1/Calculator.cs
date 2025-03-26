using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalidocode_Kata1
{
    public class Calculator
    {
        public static string errorMessage = "";

        public int Add(string? input)
        {
            List<int> numbers = new List<int>();
            int length = input.Length; int sum = 0;

            if (string.IsNullOrEmpty(input) || input.Contains(" ")) { return 0; } // null input >> automatically sum = 0
            if (input.Contains(",,") || input.Contains(",\\n") || input.Contains("\\n,")) { throw new Exception("Incorrect format of numbers"); }
            if (input.Contains(",") || input.Contains(";"))
            {
                string[] arrNumbers = input.Split(new string[] {",", ";", "\\n"},StringSplitOptions.RemoveEmptyEntries );
                foreach (string number in arrNumbers)
                {   int num = int.Parse(number);
                    if (num >= 0) { if (num < 1000) { sum += num; } }
                    else { errorMessage += $"Negatives not allowed: {num}\n"; throw new Exception(errorMessage); }
                } return sum;
            }
            if (input.Contains("//")) { sum = CustomDelimiters(input); return sum; }
            try { sum = int.Parse(input); 
                if (sum >= 0) { if (sum < 1000) {return sum; } }
                errorMessage += $"Negatives not allowed: {sum}\n"; throw new Exception(errorMessage);} 
            catch { return -1; }
        }

        public int CustomDelimiters(string input)
        {
            int sum = 0;
            int indexOfN = input.IndexOf("n");
            string stringNumbers = input.Remove(0, indexOfN + 1);

           
                string delimiter = input.Substring(2, (indexOfN - 3));
                string[] arrNumbers = stringNumbers.Split(delimiter);
                foreach (string number in arrNumbers)
                {
                    int num = int.Parse(number); if (num >= 0) { if (num < 1000) { sum += num; } }
                    else { errorMessage += $"Negatives not allowed: {num}\n"; throw new Exception(errorMessage); }
                } Console.WriteLine(sum);  
            
            return sum;
        }
    }//class
}//ns
