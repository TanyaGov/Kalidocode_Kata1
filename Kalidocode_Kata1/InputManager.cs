namespace Kalidocode_Kata1
{
    public class InputManager
    {
        ConvertStringNumbers numberConverter = new ConvertStringNumbers();
        DelimiterManager delimiterManager = new DelimiterManager();
        Calculator calculator = new Calculator();
        NegativeNumbersManager negativeNumbersManager = new NegativeNumbersManager();

        public static readonly string[] DelimitersUsed = { ",", "\n", "//"};

        public int ProccessInputAndReturnSum (string input) 
        { 
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }

            if (DelimitersUsed.Any(input.Contains))
            {
                string[] numbers = delimiterManager.ProcessDelimiters(input);
                List<int> numbersSum = numberConverter.ConvertStringArrayToNumbers(numbers);
                negativeNumbersManager.CheckForNegativeNumbers(numbersSum);
                return calculator.Add(numbersSum);
            }

            return numberConverter.ConvertOneNumber(input);
        }
    }
}
