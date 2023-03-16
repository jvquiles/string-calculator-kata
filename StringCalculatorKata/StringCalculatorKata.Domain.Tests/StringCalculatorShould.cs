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
            var result = StringCalculator.Add("");
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void AddOneNumber()
        {
            var result = StringCalculator.Add("1");
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void AddTwoNumbers()
        {
            var result = StringCalculator.Add("1,2");
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void AddThreeNumbers()
        {
            var result = StringCalculator.Add("1,2,3");
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void AddFourNumbers()
        {
            var result = StringCalculator.Add("1,2,3,4");
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void AddNumbersWithNewLineAsSeparator()
        {
            var result = StringCalculator.Add("1\n2,3");
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void AddNumbersSpecificSeparator()
        {
            var result = StringCalculator.Add("//;\n1;2");
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void AddNumbersSpecificSeparatorWithThreeNumbers()
        {
            var result = StringCalculator.Add("//;\n1;2;3");
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void AddNumbersSpecificSeparatorWithFourNumbers()
        {
            var result = StringCalculator.Add("//;\n1;2;3;4");
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void AddNumbersDifferentSpecificSeparatorWithFourNumbers()
        {
            var result = StringCalculator.Add("//-\n1-2-3-4");
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void AddNegativeNumbers()
        {
            var exception = Assert.Throws<Exception>(() => StringCalculator.Add("//;\n1;-2"));
            Assert.That(exception.Message, Is.EqualTo("negatives not allowed -2"));
        }

        [Test]
        public void AddTwoNegativeNumbers()
        {
            var exception = Assert.Throws<Exception>(() => StringCalculator.Add("//;\n1;-2;-3"));
            Assert.That(exception.Message, Is.EqualTo("negatives not allowed -2 -3"));
        }

        [Test]
        public void AddIgnoringNumbersAbove1000()
        {
            var result = StringCalculator.Add("//;\n1;2;1001");
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void AddIgnoringTwoNumbersAbove1000()
        {
            var result = StringCalculator.Add("//;\n1;2;1001;2000");
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void AddUsesComposedSeparator()
        {
            var result = StringCalculator.Add("//[***]\n1***2***3");
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void AddUsesTwoCharsComposedSeparator()
        {
            var result = StringCalculator.Add("//[;;]\n1;;2");
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void AddUsesMultipleSeparator()
        {
            var result = StringCalculator.Add("//[;][#]\n1;2#3");
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void AddUsesTwoCharsMultipleSeparator()
        {
            var result = StringCalculator.Add("//[;;][###]\n1;;2###3");
            Assert.That(result, Is.EqualTo(6));
        }
    }
}