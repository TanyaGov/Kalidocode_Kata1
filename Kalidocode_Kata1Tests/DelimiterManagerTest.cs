using Kalidocode_Kata1;

namespace Kalidocode_Kata1Tests
{
    public class DelimiterManagerTest
    {
        public DelimiterManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new DelimiterManager();
        }

        [Test]
        public void GIVEN_StandardDelimiters_WHEN_ProcessDelimiters_THEN_ReturnsNumbersArray()
        {
            //Arrange
            string input = "1,2\n3";
            string[] expectedResult = {"1", "2", "3" };

            //Act 
            string[] actualResult = manager.ProcessDelimiters(input);

            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GIVEN_SingleCustomDelimiter_WHEN_ProcessDelimiters_THEN_ReturnsNumbersArray()
        {
            //Arrange
            string input = "//***\n1***2***3";
            string[] expectedResult = {"\n1", "2", "3" };

            //Act 
            string[] actualResult = manager.ProcessDelimiters(input);

            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GIVEN_MultipleCustomDelimiter_WHEN_ProcessDelimiters_THEN_ReturnsNumbersArray()
        {
            //Arrange
            string input = "//[***][&]\n1***2&3";
            string[] expectedResult = { "\n1", "2", "3" };

            //Act 
            string[] actualResult = manager.ProcessDelimiters(input);

            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

         [Test]
        public void GIVEN_MultipleCustomDelimiter_WHEN_ProccessCustomDelimiters_THEN_ReturnsNumbersArray()
        {
            //Arrange
            string input = "//[***][&]\n1***2&3";
            string[] expectedResult = { "\n1", "2", "3" };

            //Act 
            string[] actualResult = manager.ProccessCustomDelimiters(input);

            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GIVEN_OneCustomDelimiter_WHEN_ProccessCustomDelimiters_THEN_ReturnsNumbersArray()
        {
            //Arrange
            string input = "//***\n1***2***3";
            string[] expectedResult = { "\n1", "2", "3" };

            //Act 
            string[] actualResult = manager.ProccessCustomDelimiters(input);

            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}
