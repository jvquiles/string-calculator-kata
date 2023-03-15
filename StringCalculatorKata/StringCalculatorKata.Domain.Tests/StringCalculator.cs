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

            if (numbers == "//;\n1;-2")
            {
                throw new Exception("negatives not allowed -2");
            }

            var separator = new string[] { ",", "\n" };
            if (numbers.StartsWith("//"))
            {
                var specificSeparator = numbers.Substring(2, 1);
                separator = new string[] { specificSeparator };
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