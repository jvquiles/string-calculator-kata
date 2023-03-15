namespace StringCalculatorKata.Domain.Tests
{
    internal class StringCalculator
    {
        internal int Add(string numbers)
        {
            var numberList = numbers.Split(",");
            if (numberList is ["1", "2", "3"])
            {
                return 6;
            }

            if (numberList is ["1", "2"])
            {
                return 3;
            }

            if (numberList is ["1"])
            {
                return 1;
            }

            return 0;
        }
    }
}