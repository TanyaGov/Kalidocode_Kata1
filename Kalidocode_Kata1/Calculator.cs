namespace Kalidocode_Kata1
{
    public class Calculator
    {
        public int Add(List<int> numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                if (number < 1000)
                {
                    sum += number;
                }
            }

            return sum;
        }
    }
}
