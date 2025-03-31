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

            if (customDelimiterSplit.Any(input.Contains)) 
            {
             
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
