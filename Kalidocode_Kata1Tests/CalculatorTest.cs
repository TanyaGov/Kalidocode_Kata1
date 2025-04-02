
using Kalidocode_Kata1;

namespace Kalidocode_Kata1Tests
{
    public class CalculatorTest
    {
        public Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void GIVEN_Add_WHEN_Called_THEN_ReturnsSum()
        {
            //Arrange
            List<int> numbers = new List<int>() { 8, 2, 10 };

            //Act 
            int sum = calculator.Add(numbers);

            //Assert
            Assert.That(sum, Is.EqualTo(20));
        }
    }
}
