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

        [Test]
        public void GivenOneNumber_WhenAdded_ReturnsThatNumber()
        {
            //Arrange
            string input = "92";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(92));
        }

        [Test]
        public void GivenTwoNumber_WhenAdded_ReturnsSum()
        {
            //Arrange
            string input = "92,12";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(104));
        }

        [Test]
        public void GivenCommas_WhenAdded_ReturnsSum()
        {
            // Arrange
            string input = "33,44,55";
            Calculator calculator = new Calculator();

            // Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(132));
        }

        [Test]
        public void GivenNextLine_WhenAdded_ReturnsSum()
        {
            // Arrange
            string input = "33\n44\n55";
            Calculator calculator = new Calculator();

            // Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(132));
        }

        [Test]
        public void GivenBothCommasAndNextLine_WhenAdded_ReturnsSum()
        {
            // Arrange
            string input = "33\n44,55";
            Calculator calculator = new Calculator();

            // Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(132));
        }

        [Test]
        public void GivenSingleCustomDelimiter_WhenAdded_ReturnsSum()
        {
            //Arrange
            string input = "//*\n19*4*16";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(39));
        }
    }
}
