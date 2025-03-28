namespace Kalidocode_Kata1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter numbers:");
            string input = "";
            string line = "";

            while ((input = Console.ReadLine()) != null)
            {
                line += input +"\n";
            }

            Calculator calculator = new Calculator();
            int sum = calculator.Add(line);
            Console.WriteLine(sum);
        }
    }
}