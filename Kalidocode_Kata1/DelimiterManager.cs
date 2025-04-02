namespace Kalidocode_Kata1
{
    public class DelimiterManager
    {
        public string[] ProccessStandardDelimiters(string input)
        {
            string[] standardDelimiters = { ",", "\n" };
            string[] numbers = input.Split(standardDelimiters, StringSplitOptions.None);
            return numbers;
        }


    }
}
