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

        [Test]
        public void GIVEN_OneNumber_WHEN_Added_THEN_ReturnsThatNumber()
        {
            //Arrange
            string input = "27";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(27));
        }

        [Test]
        public void GIVEN_TwoNumbers_WHEN_Added_THEN_ReturnsSum()
        {
            //Arrange
            string input = "27,49";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(76));
        }

        [Test]
        public void GIVEN_Commas_WHEN_Added_THEN_ReturnsSum()
        {
            //Arrange
            string input = "27,49,99";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(175));
        }

        [Test]
        public void GIVEN_UnknownAmountOfNumbers_WHEN_Added_THEN_ReturnsSum()
        {
            //Arrange
            string input = "27,49,99,22,19,14,91";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(321));
        }

        [Test]
        public void GIVEN_NextLine_WHEN_Added_THEN_ReturnsSum()
        {
            //Arrange
            string input = "27\n49\n99";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(175));
        }

        [Test]
        public void GIVEN_BothCommasAndNextLine_WHEN_Added_THEN_ReturnsSum()
        {
            //Arrange
            string input = "27,49\n99";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(175));
        }

        [Test]
        public void GIVEN_SingleCustomDelimiter_WHEN_Added_THEN_ReturnsSum()
        {
            //Arrange
            string input = "//*\n27*49*99";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(175));
        }

        [Test]
        public void GIVEN_OneNegativeNumber_WHEN_Added_THEN_ReturnsError()
        {
            //Arrange
            string input = "27,49,99,-4";
            Calculator calculator = new Calculator();
            
            //Act 
            Exception ex = Assert.Throws<ArgumentOutOfRangeException>(() => calculator.Add(input));

            //Assert
            Assert.That(ex.Message, Does.Contain("-4"));
        }

        [Test]
        public void GIVEN_MultipleNegativeNumber_WHEN_Added_THEN_ReturnsError()
        {
            //Arrange
            string input = "27,-9,49,99,-4";
            Calculator calculator = new Calculator();

            //Act 
            Exception ex = Assert.Throws<ArgumentOutOfRangeException>(() => calculator.Add(input));

            //Assert
            Assert.That(ex.Message, Does.Contain("-9,-4"));
        }

        [Test]
        public void GIVEN_NumberOver1000_WHEN_Added_THEN_ReturnsSumIgnoringOver1000()
        {
            //Arrange
            string input = "1027,9,49,99,4";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(161));
        }

        [Test]
        public void GIVEN_MultipleCustomDelimiters_WHEN_Added_THEN_ReturnsSum()
        {
            //Arrange
            string input = "//[***][&]\n27***9&49***99&4";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.Add(input);

            //Assert
            Assert.That(sum, Is.EqualTo(188));
        }

        [Test]
        public void GIVEN_ConvertStringNumbers_WHEN_Called_THEN_ReturnsIntegerNumbersList()
        {
            //Arrange
            string[] input = { "8", "14", "92" };
            Calculator calculator = new Calculator();
            List<int> expectedResult = new List<int> { 8, 14, 92 };

            //Act
            List<int> actualResult = calculator.ConvertStringNumbers(input);

            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GIVEN_CheckForNegativeNumbers_WHEN_Called_THEN_ReturnsError()
        {
            //Arrange
            List<int> input = new List<int> { 8, -14, 92 };
            Calculator calculator = new Calculator();

            //Act 
            Exception ex = Assert.Throws<ArgumentOutOfRangeException>(() => calculator.CheckForNegativeNumbers(input));

            //Assert
            Assert.That(ex.Message, Does.Contain("-14"));
        }

        [Test]
        public void GIVEN_GetSumOfNumbers_WHEN_Called_THEN_ReturnsSum()
        {
            //Arrange
            string[] input = { "8", "14", "92" };
            Calculator calculator = new Calculator();
           
            //Act
            int sum = calculator.GetSumOfNumbers(input);

            //Assert
            Assert.That(sum, Is.EqualTo(114));
        }

        [Test]
        public void GIVEN_CustomDelimiters_WHEN_Called_THEN_ReturnsSum()
        {
            //Arrange
            string input = "//*\n8*14*92";
            Calculator calculator = new Calculator();

            //Act
            int sum = calculator.CustomDelimiters(input);

            //Assert
            Assert.That(sum, Is.EqualTo(114));
        }
    }
}
