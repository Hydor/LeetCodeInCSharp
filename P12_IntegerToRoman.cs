using System.Text;

namespace LeetCode
{
    public class Solution
    {
        public string IntToRoman(int num)
        {
            var resultString = new StringBuilder();
            if (num >= 1000)
            {
                var m = num / 1000;
                num = num % 1000;
                resultString.Append(GetSubString("M", "", "", m));
            }
            if (num >= 100)
            {
                var c = num / 100;
                num = num % 100;
                resultString.Append(GetSubString("C", "M", "D", c));
            }
            if (num >= 10)
            {
                var x = num / 10;
                num = num % 10;
                resultString.Append(GetSubString("X", "C", "L", x));
            }
            resultString.Append(GetSubString("I", "X", "V", num));


            return resultString.ToString();
        }


        public string GetSubString(string rome, string nextRome, string five, int times)
        {
            var str = new StringBuilder();
            switch (times)
            {
                case 1:
                case 2:
                case 3:
                    for (var i = 0; i < times; i++) { str.Append(rome); }
                    break;
                case 4: str.Append(rome); str.Append(five); break;
                case 5: str.Append(five); break;
                case 6:
                case 7:
                case 8:
                    str.Append(five);
                    for (var i = 0; i < times - 5; i++) { str.Append(rome); }
                    break;
                case 9: str.Append(rome); str.Append(nextRome); break;

            }
            return str.ToString();
        }
    }
}
