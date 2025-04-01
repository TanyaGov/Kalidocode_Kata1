namespace Kalidocode_Kata1
{
    public class Calculator
    {
        string[] standardDelimiters = { "," };

        public int Add(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }

            if (standardDelimiters.Any(input.Contains))
            {
                string[] arrNumbers = input.Split(standardDelimiters, StringSplitOptions.None);
                int sum = 0;
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
