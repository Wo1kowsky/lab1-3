using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_3
{
    public static class Logic
    {
        public static List<string> FilterNumbers(List<string> numbers)
        {
            return numbers
                .FindAll((number) => AverageLessThan(number) && IsMaxDigit7(number));
        }

        static private bool AverageLessThan(string number)
        {
            var average = number
                .Select((c) => int.Parse(c.ToString()))
                .Average();

            return average < 7;
        }

        static private bool IsMaxDigit7(string number)
        {
            var max = number
                .Select((c) => int.Parse(c.ToString()))
                .Max();

            return max == 7;
        }
    }
}
