namespace Kalidocode_Kata1
{
    public class NegativeNumbersManager
    {
        public bool CheckForNegativeNumbers(List<int> numbers)
        {
            bool negativeFound = false;
            string negativesFoundErrorMessage = "Negative numbers found: ";

            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    negativeFound = true;
                    negativesFoundErrorMessage += number.ToString();
                }
            }

            if (negativeFound) 
            { 
                NegativeNumbersFoundError(negativesFoundErrorMessage);
            }

            return negativeFound;
        }

        public ArgumentOutOfRangeException NegativeNumbersFoundError(string negativesFoundErrorMessage)
        {
            throw new ArgumentOutOfRangeException(negativesFoundErrorMessage);
        }

    }
}
