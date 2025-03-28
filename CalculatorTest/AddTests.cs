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
        public void GivenOneNumber_WhenAdded_ReturnsThatNumber()
        {
            // Arrange
            string input = "19";
            Calculator calculator = new Calculator();

            // Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(19));
        }

        [Test]
        public void GivenCommas_WhenAdded_ReturnsSum()
        {
            // Arrange
            string input = "80,49,20";
            Calculator calculator = new Calculator();

            // Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(149));
        }

        [Test]
        public void GivenNextLine_WhenAdded_ReturnsSum()
        {
            // Arrange
            string input = "80\n49\n20";
            Calculator calculator = new Calculator();

            // Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(149));
        }

        [Test]
        public void GivenBothNextLineAndCommas_WhenAdded_ReturnsSum()
        {
            // Arrange
            string input = "80\n49,20";
            Calculator calculator = new Calculator();

            // Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(149));
        }

        [Test]
        public void GivenSingleCustomDelimiter_WhenAdded_ReturnsSum()
        {
            //Arrange
            string input = "//%\n78%11%2";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(91));
        }

        [Test]
        public void GivenSingleLongDelimiter_WhenAdded_ReturnsSum()
        {
            //Arrange
            string input = "//***\n99***2***101";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(202));
        }

        [Test]
        public void GivenMultipleCustomDelimiters_WhenUsingAll_ReturnsSum()
        {
            //Arrange
            string input = "//[***][&][^]\n9***3***3&5^5";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(25));
        }

        [Test]
        public void GivenNumberOver1000_WhenAdded_ReturnsSumWithout1000()
        {
            //Arrange
            string input = "1021,42,8";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(50));
        }

        [Test]
        public void GivenNegativeNumber_WhenAdded_ReturnsError()
        {
            //Arrange
            string input = "2\n-4\n9";
            Calculator calculator = new Calculator();

            //Act 
            Exception ex = Assert.Throws<Exception>(() => calculator.Add(input));

            //Assert
            Assert.That(ex.Message, Does.Contain("-4"));
        }

        [Test]
        public void GivenMultipleNegativeNumbers_WhenAdded_ReturnsError()
        {
            //Arrange
            string input = "2\n-4\n-9,7,8,-5";
            Calculator calculator = new Calculator();

            //Act 
            Exception ex = Assert.Throws<Exception>(() => calculator.Add(input));

            //Assert
            Assert.That(ex.Message, Does.Contain("-4\t-9\t-5"));
        }


    }
}
