using Kalidocode_Kata1;

namespace CalculatorTest
{
    public class Tests
    {
        [Test]
        public void GivenEmpty_WhenAdded_ReturnsZero()
        {
            // Arrange
            string input = "";
            Calculator calculator = new Calculator();

            // Act
            int sum = calculator.Add(input);

            // Assert
            Assert.That(sum, Is.EqualTo(0));
        }

        [Test]
        public void GivenWhitSpace_WhenAdded_ReturnsZero()
        {
            // Arrange
            string input = " ";
            Calculator calculator = new Calculator();

            // Act
            int sum = calculator.Add(input);

            // Assert
            Assert.That(sum, Is.EqualTo(0));
        }

        [Test]
        public void GivenOneNumber_WhenAdded_ReturnsThatNumber()
        {
            // Arrange
            string input = "47";
            Calculator calculator = new Calculator();

            // Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(47));
        }

        [Test]
        public void GivenTwoNumbers_WhenAdded_ReturnsSumOfTwoNumbers()
        {
            // Arrange
            string input = "2,9";
            Calculator calculator = new Calculator();

            // Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(11));
        }

        [Test]
        public void GivenUnkownAmountOfNumbers_WhenAdded_ReturnsSumAllNumbers()
        {
            // Arrange
            string input = "4,7,16,42,89,26,72,111";
            Calculator calculator = new Calculator();

            // Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(367));
        }

    }
}
