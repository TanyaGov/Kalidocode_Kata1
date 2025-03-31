namespace Kalidocode_Kata1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = "";
            string line = "";

            Console.WriteLine("Please enter numbers:");

            while ((input = Console.ReadLine()) != null)
            {
                line += input + "\n";
            }

            Calculator calculator = new Calculator();
            int sum = calculator.Add(line);
            Console.WriteLine($"Sum of numbers is: {sum}");
        }
    }
}