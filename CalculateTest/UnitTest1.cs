using Kalidocode_Kata1;

namespace CalculateTest
{
    public class Tests
    {

        [Test]
        public void GivenNull_WhenAdded_ReturnsZero()
        {
            // Arrange
            var input = "";
            Calculator calculator = new Calculator();

            // Act
            var sum = calculator.Add(input);

            // Assert
            Assert.That(sum, Is.EqualTo(0));
        }
    }
}
