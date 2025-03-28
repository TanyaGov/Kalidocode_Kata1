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
                int sum = 0;
                string[] arrNumbers = input.Split(standardDelimiters, StringSplitOptions.RemoveEmptyEntries);

                foreach (string number in arrNumbers) 
                {
                    sum += Convert.ToInt32(number);
                }

                return sum;
            }

            return Convert.ToInt32(input);
        }
    }
}
