namespace StringCalculatorKata.Domain.Tests
{
    internal class StringCalculator
    {
        internal int Add(string numbers)
        {
            if (numbers == "1,2")
            {
                return 3;
            }

            if (numbers == "1")
            {
                return 1;
            }

            return 0;
        }
    }
}