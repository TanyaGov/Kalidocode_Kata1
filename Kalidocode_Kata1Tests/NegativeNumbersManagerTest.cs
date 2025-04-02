using Kalidocode_Kata1;

namespace Kalidocode_Kata1Tests
{
    public class NegativeNumbersManagerTest
    {
        public NegativeNumbersManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new NegativeNumbersManager();
        }

        [Test]
        public void GIVEN_CheckForNegativeNumbers_WHEN_Called_THEN_ReturnsTrue()
        {
            //Arrange
            List<int> numbers = new List<int>() {5, 9, 2, 4 };

            // Act
            bool result = manager.CheckForNegativeNumbers(numbers);

            //Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void GIVEN_CheckForNegativeNumbers_WHEN_Called_THEN_ReturnsError()
        {
            //Arrange
            List<int> numbers = new List<int>() { -42, 9, -62, -3 };

            // Act and Assert
            Assert.That(() => manager.CheckForNegativeNumbers(numbers),
                              Throws.TypeOf<ArgumentOutOfRangeException>()
                              .With.Message.Contain("-42,-62,-3"));
        }

        [Test]
        public void GIVEN_NegativeNumbersFoundError_WHEN_Called_THEN_ReturnsError()
        {
            //Arrange
            string negativesFoundErrorMessage = "Negative numbers found: -4";

            // Act and Assert
            Assert.That(() => manager.NegativeNumbersFoundError(negativesFoundErrorMessage),
                              Throws.TypeOf<ArgumentOutOfRangeException>()
                              .With.Message.Contain("Negative numbers found: -4"));
        }
    }
}
