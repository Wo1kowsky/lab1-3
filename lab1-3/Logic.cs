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
            if (number.Length > 0)
            {
                var average = number
                    .Select((c) => int.Parse(c.ToString()))
                    .Average();

                return average < 7;
            }
            else
            {
                return false;
            }
        }

        static private bool IsMaxDigit7(string number)
        {
            if (number.Length > 0)
            {
                var max = number
                    .Select((c) => int.Parse(c.ToString()))
                    .Max();

                return max == 7;
            }
            else
            {
                return false;
            }
        }
    }
}
