using System;
using Kalidocode_Kata1;

namespace Kalidocode_Kata1Tests
{
    public class CalculatorTest
    {
        public Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void GIVEN_CAdd_WHEN_Called_THEN_ReturnsConvertedNumber()
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
