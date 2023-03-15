namespace StringCalculatorKata.Domain.Tests
{
    public class StringCalculatorShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SumStringEmpty()
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("");
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void SumOne()
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1");
            Assert.That(result, Is.EqualTo(1));
        }
    }
}