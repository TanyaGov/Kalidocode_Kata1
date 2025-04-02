namespace Kalidocode_Kata1
{
    public class InputManager
    {
        ConvertStringNumbers converter = new ConvertStringNumbers();
        public int ProccessInputAndReturnSum (string input) 
        { 
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }

            return converter.ConvertNumber(input);
        }
    }
}
