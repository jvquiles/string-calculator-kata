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

            var separator = new string[] { ",", "\n" };
            if (numbers.StartsWith("//;"))
            {
                separator = new string[] { ";" };
                numbers = numbers.Remove(0, 3);
            }

            var numberSum = numbers.Split(separator, StringSplitOptions.None)
                .Where(x => !string.IsNullOrEmpty(x.Trim()))
                .Select(x => Convert.ToInt32(x))
                .Sum();

            return numberSum;
        }
    }
}