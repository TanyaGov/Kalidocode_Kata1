namespace Kalidocode_Kata1
{
    public class Calculator
    {
        public int Add(string input)
        {
            string[] standardDelimiters = { ",", "\n" };

            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
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
            List<int> list = new List<int>();

            foreach (string number in arrNumbers)
            {
                sum += Convert.ToInt32(number);
            }

            return sum;
        }
    }
}
