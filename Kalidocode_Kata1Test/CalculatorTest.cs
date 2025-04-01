﻿using Kalidocode_Kata1;

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
    }
}
