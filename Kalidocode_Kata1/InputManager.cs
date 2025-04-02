namespace Kalidocode_Kata1
{
    public class InputManager
    {
        ConvertStringNumbers numberConverter = new ConvertStringNumbers();
        DelimiterManager delimiterManager = new DelimiterManager();
        Calculator calculator = new Calculator();

        public int ProccessInputAndReturnSum (string input) 
        { 
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }

            string[] numbers = delimiterManager.ProcessDelimiters(input);
            List<int> numbersSum = numberConverter.ConvertStringArrayToNumbers(numbers);
            return calculator.Add(numbersSum);

            throw new ArgumentException("Invalid Input");
        }
    }
}
