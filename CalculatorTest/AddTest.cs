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


        [Test]
        public void GivenCommas_WhenAdded_ReturnsSum()
        {
            // Arrange
            string input = "92,47,51";
            Calculator calculator = new Calculator();

            // Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(190));
        }

        [Test]
        public void GivenNextLine_WhenAdded_ReturnsSum()
        {
            // Arrange
            string input = "72\n97\n14";
            Calculator calculator = new Calculator();

            // Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(183));
        }

        [Test]
        public void GivenBothNextLineAndCommas_WhenAdded_ReturnsSum()
        {
            // Arrange
            string input = "19,572\n2";
            Calculator calculator = new Calculator();

            // Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(593));
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


        [Test]
        public void GivenNumberOver1000_WhenAdded_ReturnsSumWithout1000()
        {
            //Arrange
            string input = "1099,7,21";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(28));
        }

        [Test]
        public void GivenNegativeNumber_WhenAdded_ReturnsError()
        {
            //Arrange
            string input = "14\n-2\n92";
            Calculator calculator = new Calculator();

            //Act 
            Exception ex = Assert.Throws<Exception>(() => calculator.Add(input));

            //Assert
            Assert.That(ex.Message, Does.Contain("-2"));
        }

        [Test]
        public void GivenMultipleNegativeNumbers_WhenAdded_ReturnsError()
        {
            //Arrange
            string input = "2\n-22\n-4,7,8,-17";
            Calculator calculator = new Calculator();

            //Act 
            Exception ex = Assert.Throws<Exception>(() => calculator.Add(input));

            //Assert
            Assert.That(ex.Message, Does.Contain("-22,-4,-17"));
        }

        [Test]
        public void GivenSingleLongDelimiter_WhenAdded_ReturnsSum()
        {
            //Arrange
            string input = "//***\n107***3***101";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(211));
        }

        [Test]
        public void GivenMultipleCustomDelimiters_WhenUsingAll_ReturnsSum()
        {
            //Arrange
            string input = "//[***][&][^]\n4***30***6&10^5";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(55));
        }
    }
}
