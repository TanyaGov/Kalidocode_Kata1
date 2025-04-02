using Kalidocode_Kata1;

namespace Kalidocode_Kata1Tests
{
    public class Tests
    {
        public InputManager manager;

        [SetUp]
        public void Setup()
        {
             manager = new InputManager();
        }

        [Test]
        public void GIVEN_EmptyString_WHEN_Processed_THEN_ReturnsZero()
        {
            //Arrange
            string input = " ";

            //Act 
            int result = manager.ProccessInputAndReturnSum(input);

            //Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void GIVEN_TwoNumbers_WHEN_Processed_THEN_ReturnsSum()
        {
            //Arrange
            string input = "2,5";

            //Act 
            int result = manager.ProccessInputAndReturnSum(input);

            //Assert
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void GIVEN_Commas_WHEN_Processed_THEN_ReturnsSum()
        {
            //Arrange
            string input = "2,5,3,9";

            //Act 
            int result = manager.ProccessInputAndReturnSum(input);

            //Assert
            Assert.That(result, Is.EqualTo(19));
        }

        [Test]
        public void GIVEN_NextLine_WHEN_Processed_THEN_ReturnsSum()
        {
            //Arrange
            string input = "2\n5\n3\n9";

            //Act 
            int result = manager.ProccessInputAndReturnSum(input);

            //Assert
            Assert.That(result, Is.EqualTo(19));
        }

        [Test]
        public void GIVEN_BothCommasAndNextLine_WHEN_Processed_THEN_ReturnsSum()
        {
            //Arrange
            string input = "2,5\n3,9";

            //Act 
            int result = manager.ProccessInputAndReturnSum(input);

            //Assert
            Assert.That(result, Is.EqualTo(19));
        }
    }
}
