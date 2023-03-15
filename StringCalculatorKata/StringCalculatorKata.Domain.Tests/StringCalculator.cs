namespace StringCalculatorKata.Domain.Tests
{
    internal class StringCalculator
    {
        internal int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            var numberSum = numbers.Split(",")
                .Select(x => Convert.ToInt32(x))
                .Sum();

            return numberSum;
        }
    }
}