namespace Kalidocode_Kata1
{
    public class ConvertStringNumbers
    {
        public int ConvertOneNumber(string number)
        {
            return Convert.ToInt32(number);
        }

        public List<int> ConvertStringArrayToNumbers(string[] inputNumbers)
        {
            List<int> numbers = new List<int>();

            foreach (string number in inputNumbers) 
            { 
                numbers.Add(ConvertOneNumber(number));
            }

            return numbers;
        }
    }
}
