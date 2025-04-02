namespace Kalidocode_Kata1
{
    public class InputManager
    {
        ConvertStringNumbers numberConverter = new ConvertStringNumbers();
        DelimiterManager delimiterManager = new DelimiterManager();
        Calculator calculator = new Calculator();

        public static readonly string[] StandardDelimiters = { ",", "\n" };
        //public const string CustomDelimiterPresent = "//";
        //public static readonly string[] CustomDelimitersSplit = { "[", "]" };

        public int ProccessInputAndReturnSum (string input) 
        { 
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }

            if (StandardDelimiters.Any(input.Contains))
            {
                string[] numbers = delimiterManager.ProccessStandardDelimiters(input);
                List<int> numbersSum = numberConverter.ConvertStringArrayToNumbers(numbers);
                return calculator.Add(numbersSum);
            }
            
            throw new ArgumentException("Invalid Input");
        }
    }
}
