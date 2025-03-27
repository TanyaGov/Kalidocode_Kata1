using Kalidocode_Kata1;

namespace CalculateTest
{
    public class Tests
    {

        [Test]
        public void GivenEmpty_WhenAdded_ReturnsZero()
        {
            // Arrange
            string input = " ";
            Calculator calculator = new Calculator();
            // Act
            var sum = calculator.Add(input);
            // Assert
            Assert.That(sum, Is.EqualTo(0));
        }

        [Test]
        public void GivenNull_WhenAdded_ReturnsZero()
        {
            // Arrange
            string input = null;
            Calculator calculator = new Calculator();
            // Act
            var sum = calculator.Add(input);
            // Assert
            Assert.That(sum, Is.EqualTo(0));
        }


    }
}
