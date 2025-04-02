namespace Kalidocode_Kata1
{
    public class DelimiterManager
    {
        public static readonly string[] StandardDelimiters = { ",", "\n" };
        public const string CustomDelimiterPresent = "//";
        public static readonly string[] CustomDelimitersSplit = { "[", "]" };

        public string[] ProcessDelimiters(string input)
        {
            string[] delimiters; 

            if (input.Contains(CustomDelimiterPresent))
            {
                delimiters = ProccessCustomDelimiters(input);
            }
            else if (StandardDelimiters.Any(input.Contains))
            {
                delimiters = StandardDelimiters;
            }
            else
            {
                throw new ArgumentException("Input not in correct format: Delimiters not supported");
            }

            string[] numbers = input.Split(delimiters, StringSplitOptions.None);
            return numbers;
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

            return delimiters;
        }
    }
}
