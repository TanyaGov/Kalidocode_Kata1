namespace Kalidocode_Kata1
{
    public class DelimiterManager
    {
        public static readonly string[] StandardDelimiters = { ",", "\n" };
        public const string CustomDelimiterPresent = "//";
        public static readonly string[] CustomDelimitersSplit = { "[", "]" };
        string inputNumbers = "";

        public string[] ProcessDelimiters(string input)
        {
            if (input.Contains(CustomDelimiterPresent))
            {
                return ProccessCustomDelimiters(input);
            }
            
            if (StandardDelimiters.Any(input.Contains))
            {
                string[] numbers = input.Split(StandardDelimiters, StringSplitOptions.None);
                return numbers;
            }
            
            throw new ArgumentException("Input not in correct format: Delimiters not supported");
        }

        public string[] ProccessCustomDelimiters(string input)
        {
            int indexStartDelimiter = input.IndexOf(CustomDelimiterPresent) + CustomDelimiterPresent.Length;
            int indexNextLine = input.IndexOf("\n");
            int delimiterLength = indexNextLine - indexStartDelimiter;

            string customDelimiters = input.Substring(indexStartDelimiter, delimiterLength);
            string inputNumbers = input.Substring(indexNextLine);

            string[] delimiters = (CustomDelimitersSplit.Any(customDelimiters.Contains))
            ? customDelimiters.Split(CustomDelimitersSplit, StringSplitOptions.None)
            : new string[] { customDelimiters };

            string[] numbers = inputNumbers.Split(delimiters, StringSplitOptions.None);
            return numbers;
        }
    }
}
