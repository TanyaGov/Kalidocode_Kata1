namespace Kalidocode_Kata1
{
    public class Calculator
    {
        string customDelimiter = "//";
        string[] customDelimiterSplit = { "[", "]" };
        string[] standardDelimiters = { "\n", "," };

        public int Add(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }

            if (input.Contains(customDelimiter)) 
            {
                return CustomDelimiters(input);
            }

            if (standardDelimiters.Any(input.Contains))
            {
                string[] arrNumbers = input.Split(standardDelimiters, StringSplitOptions.None);
                return GetSum(arrNumbers);
            }

            return Convert.ToInt32(input);
        }

        public int CustomDelimiters(string input)
        {
            int indexStartDelimiter = input.IndexOf(customDelimiter) + customDelimiter.Length;
            int indexNextLine = input.IndexOf("\n");

            string delimiters = input.Substring(indexStartDelimiter, indexNextLine - indexStartDelimiter);
            string numbers = input.Substring(indexNextLine);
            
            string[] arrDelimiters = (customDelimiterSplit.Any(delimiters.Contains))
            ? delimiters.Split(customDelimiterSplit, StringSplitOptions.None)
            : new string[] { delimiters };

            string[] arrNumbers = numbers.Split(arrDelimiters, StringSplitOptions.None);
            return GetSum(arrNumbers);
        }

        public int GetSum(string[] arrNumbers)
        {
            int sum = 0;
            List<int> negatives = new List<int>();

            foreach (string number in arrNumbers) 
            { 
                int num = Convert.ToInt32(number);
                
                if (num >= 0 && num < 1000)
                {
                    sum += num;
                }
                else if (num < 0)
                {
                    negatives.Add(num);
                }
            }

            if (negatives.Any()) 
            {
                throw new ArgumentOutOfRangeException($"Negative numbers found:{string.Join(",", negatives)}");
            }

            return sum;
        }
    }
}
