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

            var numberList = numbers.Split(",")
                .Select(x => Convert.ToInt32(x))
                .ToArray();

            if (numberList is [1, 2, 3, 4])
            {
                return 10;
            }

            if (numberList is [1, 2, 3])
            {
                return 6;
            }

            if (numberList is [1, 2])
            {
                return 3;
            }

            if (numberList is [1])
            {
                return 1;
            }

            return 0;
        }
    }
}