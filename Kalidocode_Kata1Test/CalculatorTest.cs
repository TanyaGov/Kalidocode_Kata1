using Kalidocode_Kata1;

namespace Kalidocode_Kata1Test
{
    public class CalculatorTest
    {
        [Test]
        public void GIVEN_EmptyString_WHEN_Added_THEN_ReturnsZero()
        {
            //Arrange
            string input = " ";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum,Is.EqualTo(0));
        }
    }
}
