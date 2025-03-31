namespace Kalidocode_Kata1
{
    public class Calculator
    {
        public int Add(string input)
        {
            string[] standardDelimiters = { ",", "\n" };
            string customDelimiters = "//";
            string[] customDelimitersSplit = { "[", "]" };

            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }

            if (input.Contains(customDelimiters))
            {
                int indexStartDelimiter = input.IndexOf(customDelimiters) + customDelimiters.Length;
                int indexNextLine = input.IndexOf("\n");

                string delimiters = input.Substring(indexStartDelimiter, indexNextLine - indexStartDelimiter);
                string numbers = input.Substring(indexNextLine);

                if (customDelimitersSplit.Any(input.Contains))
                {
                    string[] arrDelimiters = delimiters.Split(customDelimitersSplit, StringSplitOptions.RemoveEmptyEntries);
                    string[] arrNumbers = numbers.Split(arrDelimiters, StringSplitOptions.RemoveEmptyEntries);
                    return GetSum(arrNumbers);
                }
                else
                {
                    string[] arrNumbers = numbers.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    return GetSum(arrNumbers);
                }
            }

            if (standardDelimiters.Any(input.Contains))
            {
                string[] arrNumbers = input.Split(standardDelimiters, StringSplitOptions.RemoveEmptyEntries);
                return GetSum(arrNumbers);
            }

            return Convert.ToInt32(input);
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
                throw new Exception($"Negative numbers found:{string.Join(",", negatives)}");
            }

            return sum;
        }
    }
}
