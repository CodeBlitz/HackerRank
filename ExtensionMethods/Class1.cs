using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class CleanCode
    {
        public static int Increment(this int number, int incrementStep)
        {
            return number + incrementStep;
        }

        public static bool IsLessThanOrEqual(this int number, int comparedNumber)
        {
            return number <= comparedNumber;
        }

        public static int AbsoluteDifference(this int firstNumber, int secondNumber)
        {
            return Math.Abs(firstNumber - secondNumber);
        }

        public static bool IsOddNumber(this int number)
        {
            return number % 2 != 0;
        }

        public static bool IsEvenNumber(this int number)
        {
            return number % 2 == 0;
        }
    }
}
