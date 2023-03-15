namespace StringCalculatorKata.Domain.Tests
{
    public class StringCalculatorShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddStringEmpty()
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

        [Test]
        public void AddFourNumbers()
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1,2,3,4");
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void AddNumbersWithNewLineAsSeparator()
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1\n2,3");
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void AddNumbersSpecificSeparator()
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("//;\n1;2");
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void AddNumbersSpecificSeparatorWithThreeNumbers()
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("//;\n1;2;3");
            Assert.That(result, Is.EqualTo(10));
        }
    }
}