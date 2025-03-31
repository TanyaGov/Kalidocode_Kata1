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

            }

            return Convert.ToInt32(input);
        }

        public int GetSum(string[] arrNumbers)
        {
            return 1;
        }
    }
}
