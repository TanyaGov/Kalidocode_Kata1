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
        public void GIVEN_OneNumber_WHEN_Processed_THEN_ReturnsThatNumber()
        {
            //Arrange
            string input = "49";

            //Act 
            int result = manager.ProccessInputAndReturnSum(input);

            //Assert
            Assert.That(result, Is.EqualTo(49));
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

        [Test]
        public void GIVEN_UnknownAmountOfNumbers_WHEN_Processed_THEN_ReturnsSum()
        {
            //Arrange
            string input = "10,20,30,40,50,60,70,80,90";

            //Act
            int result = manager.ProccessInputAndReturnSum(input);

            //Assert
            Assert.That(result, Is.EqualTo(450));
        }

        [Test]
        public void GIVEN_SingleCustomDelimiter_WHEN_Processed_THEN_ReturnsSum()
        {
            //Arrange
            string input = "//*\n60*40*5";

            //Act
            int result = manager.ProccessInputAndReturnSum(input);

            //Assert
            Assert.That(result, Is.EqualTo(105));
        }

        [Test]
        public void GIVEN_LongSingleCustomDelimiter_WHEN_Processed_THEN_ReturnsSum()
        {
            //Arrange
            string input = "//***\n60***40***5";

            //Act
            int result = manager.ProccessInputAndReturnSum(input);

            //Assert
            Assert.That(result, Is.EqualTo(105));
        }

        [Test]
        public void GIVEN_OneNegativeNumber_WHEN_Processed_THEN_ReturnsError()
        {
            //Arrange
            string input = "7,92,47,-21";
            
            // Act and Assert
            Assert.That(() => manager.ProccessInputAndReturnSum(input),
                              Throws.TypeOf<ArgumentOutOfRangeException>()
                              .With.Message.Contain("-21"));
        }

        [Test]
        public void GIVEN_MultipleNegativeNumber_WHEN_Processed_THEN_ReturnsError()
        {
            //Arrange
            string input = "7,-42,99,-62,-3";

            // Act and Assert
            Assert.That(() => manager.ProccessInputAndReturnSum(input),
                              Throws.TypeOf<ArgumentOutOfRangeException>()
                              .With.Message.Contain("-42,-62,-3"));
        }

        [Test]
        public void GIVEN_NumberOver1000_WHEN_Processed_THEN_ReturnsSumIgnoringOver1000()
        {
            //Arrange
            string input = "60,1001,40,5";

            //Act
            int result = manager.ProccessInputAndReturnSum(input);

            //Assert
            Assert.That(result, Is.EqualTo(105));
        }
    }
}
