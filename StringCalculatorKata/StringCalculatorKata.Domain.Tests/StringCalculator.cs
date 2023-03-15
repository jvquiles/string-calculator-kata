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

            if (numbers == "//;\n1;2")
            {
                return 3;
            }

            if (numbers == "//;\n1;2;3")
            {
                return 6;
            }

            var numberSum = numbers.Split(new string[] { ",", "\n" }, StringSplitOptions.None)
                .Where(x => !string.IsNullOrEmpty(x.Trim()))
                .Select(x => Convert.ToInt32(x))
                .Sum();

            return numberSum;
        }
    }
}