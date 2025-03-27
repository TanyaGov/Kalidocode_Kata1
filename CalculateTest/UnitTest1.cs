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

        [Test]
        public void Given7_WhenAdded_Returns7()
        {
            // Arrange
            var input = "7";
            Calculator calculator = new Calculator();
            // Act
            var sum = calculator.Add(input);
            //Assert
            Assert.That(sum, Is.EqualTo(7));
        }

        [Test]
        public void GivenCommasOnly_WhenAdded_ReturnsSum()
        {
            // Arrange
            var input = "8,2,20";
            Calculator calculator = new Calculator();
            // Act
            var sum = calculator.Add(input);
            //Assert
            Assert.That(sum, Is.EqualTo(30));
        }

        [Test]
        public void GivenSlashNOnly_WhenAdded_ReturnsSum()
        {
            // Arrange
            var input = "8\n2\n20";
            Calculator calculator = new Calculator();
            // Act
            var sum = calculator.Add(input);
            //Assert
            Assert.That(sum, Is.EqualTo(30));
        }

        [Test]
        public void GivenBothSlashNOnlyAndCommas_WhenAdded_ReturnsSum()
        {
            // Arrange
            var input = "8\n2,20";
            Calculator calculator = new Calculator();
            // Act
            var sum = calculator.Add(input);
            //Assert
            Assert.That(sum, Is.EqualTo(30));
        }

        [Test]
        public void GivenSingleCustomDelimiter_WhenAdded_ReturnsSum()
        {
            //Arrange
            var input = "//%\n87%11%3";
            Calculator calculator = new Calculator();
            //Act
            var sum = calculator.Add(input);
            //Assert
            Assert.That(sum, Is.EqualTo(101));
        }

        [Test]
        public void GivenLongDelimiter_WhenAdded_ReturnsSum()
        {
            //Arrange
            var input = "//***\n150***22***400";
            Calculator calculator = new Calculator();
            //Act
            var sum = calculator.Add(input);
            //Assert
            Assert.That(sum, Is.EqualTo(572));
        }

        [Test]
        public void GivenMultipleCustomDelimiters_WhenUsingAll_ReturnsSum()
        {
            //Arrange
            var input = "//[***][&][%]\n8***8&4%4";
            Calculator calculator = new Calculator();
            //Act
            var sum = calculator.Add(input);
            //Assert
            Assert.That(sum, Is.EqualTo(24));
        }

        [Test]
        public void GivenOver1000_WhenAdded_ReturnsSumWithout1000()
        {
            //Arrange
            var input = "1006,10,8";
            Calculator calculator = new Calculator();
            //Act
            var sum = calculator.Add(input);
            //Assert
            Assert.That(sum, Is.EqualTo(18));
        }

        [Test]
        public void GivenNegativeNumbers_WhenAdded_ReturnsError()
        {
            //Arrange
            var input = "-4\n9\n7";
            Calculator calculator = new Calculator();
            //Act 
            var ex = Assert.Throws<Exception>(() => calculator.Add(input));
            //Assert
            Assert.That(ex.Message, Does.Contain("-4"));
        }



    }
}
