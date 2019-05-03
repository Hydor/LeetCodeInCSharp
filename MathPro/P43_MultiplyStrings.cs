

namespace LeetCode.MathPro
{
    class P43_MultiplyStrings
    {
        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
                return "0";

            var digitResults = new int[num1.Length + num2.Length];

            for (int i = 0; i < num1.Length; i++)
            {
                for (int j = 0; j < num2.Length; j++)
                {
                    digitResults[i + j + 1] += (num1[i] - '0') * (num2[j] - '0');
                }
            }

            for (int i = num1.Length + num2.Length - 1; i > 0; i--)
            {
                digitResults[i - 1] += digitResults[i] / 10;
                digitResults[i] %= 10;
            }

            var result = "";

            var startIndex = 0;

            while (digitResults[startIndex] == 0)
            {
                startIndex++;
            }

            for (; startIndex < num1.Length + num2.Length; startIndex++)
            {
                result += digitResults[startIndex];
            }

            return result;
        }

    }
}
