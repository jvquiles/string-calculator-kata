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
        public void AddOneNumber()
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1");
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void AddTwoNumbers()
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1,2");
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void AddThreeNumbers()
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1,2,3");
            Assert.That(result, Is.EqualTo(6));
        }
    }
}