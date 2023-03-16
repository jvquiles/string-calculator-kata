namespace StringCalculatorKata.Domain.Tests
{
    internal class StringCalculator
    {
        internal static int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            var separator = new[] { ",", "\n" };
            if (numbers.StartsWith("//"))
            {
                separator = GetSeparator(numbers);
                var endOfSeparators = numbers.IndexOf("\n", StringComparison.InvariantCulture);
                numbers = numbers.Remove(0,  endOfSeparators);
            }

            var numberList = numbers.Split(separator, StringSplitOptions.None)
                .Where(x => !string.IsNullOrEmpty(x.Trim()))
                .Select(x => Convert.ToInt32(x))
                .ToList();

            var negativeNumberList = numberList
                .Where(x => x < 0)
                .ToList();

            if (negativeNumberList.Any())
            {
                throw new Exception($"negatives not allowed {string.Join(" ", negativeNumberList)}");
            }

            var numberSum = numberList
                .Where(x => x <= 1000)
                .Sum();

            return numberSum;
        }

        private static string[] GetSeparator(string numbers)
        {
            if (!numbers.Contains("["))
            {
                return new []{ numbers.Substring(2, 1) };
            }

            var delimiters = numbers.Split(new string[] {"[", "[]", "]"}, StringSplitOptions.None);
            var firstAndLast = new[] { delimiters.First(), delimiters.Last() };
            return delimiters.Except(firstAndLast).ToArray();
        }
    }
}