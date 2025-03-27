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
            int sum = 0; // 7,9 9
            string error = "Negative numbers:";

            if (string.IsNullOrEmpty(input) || input.Contains(" ")) { sum = 0; }

            if (input.Contains("//"))
            {
                int beforeSlash = 2;
                int indexNextLine = input.IndexOf("\n");
                string delimiterString = input.Substring(beforeSlash, (indexNextLine - beforeSlash));
                string numbersString = input.Substring(indexNextLine + 1);

                if (input.Contains("[") &&  input.Contains("]")) 
                {
                    string[] arrDelimiters = delimiterString.Split(new string[] { "[", "]" }, StringSplitOptions.RemoveEmptyEntries);
                    string[] arrNumbers = numbersString.Split(arrDelimiters, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string number in arrNumbers)
                    {
                        int num = int.Parse(number);
                        if (num >= 0 && num < 1000) { sum += num; }
                        else if (num < 0) { error += "\t" + number; }
                    }

                    if (!error.Equals("Negative numbers:")) { throw new Exception(error); }
                    return sum;
                }

                else
                {
                    string[] arrNumbers = numbersString.Split(delimiterString);
                    foreach (string number in arrNumbers)
                    {
                        int num = int.Parse(number);
                        if (num >= 0 && num < 1000) { sum += num; }
                        else if (num < 0) { error += "\t" + number; }
                    }

                    if (!error.Equals("Negative numbers:")) { throw new Exception(error); }
                    return sum;
                }

            }

            if (input.Contains(",") || input.Contains("\n"))
            {
                string[] arrNumbers = input.Split(new string[] { ",", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string number in arrNumbers) 
                { 
                    int num = int.Parse(number);
                    if (num >= 0 && num < 1000) { sum += num; }
                    else if (num < 0) { error += "\t" + number; }
                }
                
                if (! error.Equals("Negative numbers:")) { throw new Exception(error); }
                return sum;
            }

            


            else { sum = int.Parse(input); }
            return sum;

        }

        
    }//class

}//ns
