using Kalidocode_Kata1;

namespace CalculateTest
{
    public class Tests
    {

        [Test]
        public void GivenNull_WhenAdded_ReturnsZero()
        {
            var input = "";
            Calculator calculator = new Calculator();
            var sum = calculator.Add(input);
            Assert.That(sum, Is.EqualTo(0));
        }

        [Test]
        public void GivenEmpty_WhenAdded_ReturnsZero()
        {
            var input = " ";
            Calculator calculator = new Calculator();
            var sum = calculator.Add(input);
            Assert.That(sum, Is.EqualTo(0));
        }

        [Test]
        public void Given7_WhenAdded_Returns7()
        {
            var input = "7";
            Calculator calculator = new Calculator();
            var sum = calculator.Add(input);
            Assert.That(sum, Is.EqualTo(7));
        }

        [Test]
        public void Given42_WhenAdded_Returns42()
        {
            var input = "42";
            Calculator calculator = new Calculator();
            var sum = calculator.Add(input);
            Assert.That(sum, Is.EqualTo(42));
        }

        [Test]
        public void Given6b_WhenAdded_ReturnsNegative1()
        {
            var input = "6b";
            Calculator calculator = new Calculator();
            var sum = calculator.Add(input);
            Assert.That(sum, Is.EqualTo(-1));
        }

        [Test]
        public void GivenCommasOnly_WhenAdded_Returns30()
        {
            var input = "8,2,20";
            Calculator calculator = new Calculator();
            var sum = calculator.Add(input);
            Assert.That(sum, Is.EqualTo(30));
        }

        [Test]
        public void GivenSlashNOnly_WhenAdded_Returns30()
        {
            var input = "8\\n2\\n20";
            Calculator calculator = new Calculator();
            var sum = calculator.Add(input);
            Assert.That(sum, Is.EqualTo(30));
        }

        [Test]
        public void GivenBothSlashNOnlyAndCommas_WhenAdded_Returns30()
        {
            var input = "8\\n2,20";
            Calculator calculator = new Calculator();
            var sum = calculator.Add(input);
            Assert.That(sum, Is.EqualTo(30));
        }

        [Test]
        public void GivenPercentageDelimiter_WhenAdded_Returns101()
        {
            var input = "//%\\n87%11%3";
            Calculator calculator = new Calculator();
            var sum = calculator.Add(input);
            Assert.That(sum, Is.EqualTo(101));
        }

        [Test]
        public void GivenStarDelimiter_WhenAdded_Returns572()
        {
            var input = "//*\\n150*22*400";
            Calculator calculator = new Calculator();
            var sum = calculator.Add(input);
            Assert.That(sum, Is.EqualTo(572));
        }
    }
}
