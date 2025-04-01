namespace Kalidocode_Kata1
{
    public class Calculator
    {
        public int Add(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }
            return Convert.ToInt32(input);
        }
    }
}
