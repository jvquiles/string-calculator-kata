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
            if (numbers.StartsWith("//"))
            {
                var specificSeparator = numbers.Substring(2, 1);
                separator = new string[] { specificSeparator };
                numbers = numbers.Remove(0, 3);
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
                .Sum();

            return numberSum;
        }
    }
}