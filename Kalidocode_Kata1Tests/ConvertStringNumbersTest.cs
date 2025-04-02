using Kalidocode_Kata1;

namespace Kalidocode_Kata1Tests
{
    public class ConvertStringNumbersTest
    {
        public ConvertStringNumbers converter;

        [SetUp]
        public void Setup()
        {
            converter = new ConvertStringNumbers();
        }

        [Test]
        public void GIVEN_ConvertStringArrayToNumbers_WHEN_Called_THEN_ReturnsConvertedNumbersList()
        {
            //Arrange
            string[] input = { "2","5","3","9" };
            List<int> expectedResult = new List<int>() { 2, 5, 3, 9 };

            //Act 
            List<int> actualResult = converter.ConvertStringArrayToNumbers(input);

            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GIVEN_ConvertOneNumber_WHEN_Called_THEN_ReturnsConvertedNumber()
        {
            //Arrange
            string input = "2";

            //Act 
            int result = converter.ConvertOneNumber(input);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }
    }
}
