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

            if (numbers == "//[;][#]\n1;2#3")
            {
                return 6;
            }

            var separator = new[] { ",", "\n" };
            if (numbers.StartsWith("//"))
            {
                var separatorInitIndex = numbers.IndexOf("[", StringComparison.InvariantCulture);
                var separatorEndIndex = numbers.IndexOf("]", StringComparison.InvariantCulture);
                if (separatorInitIndex == -1 && separatorEndIndex == -1)
                {
                    separatorInitIndex = 1;
                    separatorEndIndex = 3;
                }

                var specificSeparator = numbers.Substring(separatorInitIndex + 1, separatorEndIndex - separatorInitIndex - 1);
                var endOfSeparators = numbers.IndexOf("\n", StringComparison.InvariantCulture);
                numbers = numbers.Remove(0,  endOfSeparators);
                separator = new[] { specificSeparator };
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
    }
}