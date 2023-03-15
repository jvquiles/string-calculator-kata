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
        public void SumOneNumber()
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1");
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void SumTwoNumbers()
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1,2");
            Assert.That(result, Is.EqualTo(1));
        }
    }
}