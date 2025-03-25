namespace Kalidocode_Kata1
{
    public class Program
    {
        public static string? input = null;
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a String containing the numbers you want to add, seperated by a character, such as ','");
            input = Console.ReadLine();

            Calculator calculator = new Calculator();

            int sum = calculator.Add(input);
            Console.WriteLine($"Sum is: {sum}");

        }
    }
}