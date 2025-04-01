namespace Kalidocode_Kata1
{
    public class Calculator
    {
        public static readonly string[] StandardDelimiters = { ",", "\n" };
        public const string CustomDelimiter = "//";
        public static readonly string[] MultipleCustomDelimiters = { "[", "]" };

        public int Add(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }

            if (input.Contains(CustomDelimiter))
            {
                return CustomDelimiters(input);
            }

            if (StandardDelimiters.Any(input.Contains))
            {
                string[] arrNumbers = input.Split(StandardDelimiters, StringSplitOptions.None);
                return GetSumOfNumbers(arrNumbers);
            }

            return Convert.ToInt32(input);
        }

        private int CustomDelimiters(string input)
        {
            int indexStartDelimiter = input.IndexOf(CustomDelimiter) + CustomDelimiter.Length;
            int indexNextLine = input.IndexOf("\n");
            int delimiterLength = indexNextLine - indexStartDelimiter;

            string delimiters = input.Substring(indexStartDelimiter, delimiterLength);
            string numbers = input.Substring(indexNextLine);

            string[] arrNumbers = numbers.Split(delimiters);
            return GetSumOfNumbers(arrNumbers);
        }

        private List<int> ConvertStringNumbers(string[] arrNumbers)
        {
            List<int> numbers = new List<int>();

            foreach (string number in arrNumbers)
            {
                numbers.Add(Convert.ToInt32(number));
            }

            return numbers;
        }

        private int GetSumOfNumbers(string[] arrNumbers)
        {
            List<int> numbers = ConvertStringNumbers(arrNumbers);
            CheckForNegativeNumbers(numbers);
            
            int sum = 0;

            foreach (int number in numbers) 
            { 
                sum += number;
            }

            return sum;
        }

        private void CheckForNegativeNumbers(List<int> numbers)
        {
            string negativeNumbers = "Negative numbers found:\t";

            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    negativeNumbers += number + ",";
                }
            }

            if (!negativeNumbers.Equals("Negative numbers found:\t"))
            { 
                throw new ArgumentOutOfRangeException(negativeNumbers);
            }
        }
    }
}
