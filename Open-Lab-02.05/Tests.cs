using NUnit.Framework;

namespace Open_Lab_02._05
{
    [TestFixture]
    public class Tests
    {

        private Calculator calculator;

        [OneTimeSetUp]
        public void Init() => calculator = new Calculator();

        [Test]
        public void DivisibleByFiveTest([Range(0, 299, 3)] int number) =>
            Assert.That(calculator.DivisibleByFive(number), Is.EqualTo(number % 5 == 0));

    }
}
