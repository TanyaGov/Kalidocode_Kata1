using Kalidocode_Kata1;

namespace CalculatorTest
{
    public class Tests
    {
        [Test]
        public void GivenEmpty_WhenAdded_ReturnsZero()
        {
            //Arrange
            string input = "";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(0));
        }

        [Test]
        public void GivenWhiteSpace_WhenAdded_ReturnsZero()
        {
            //Arrange
            string input = " ";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(0));
        }

    }
}
