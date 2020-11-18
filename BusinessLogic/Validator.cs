using System;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public static class Validator
    {
        /// <summary>
        /// Determines if string is a valid Social Security number
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public static bool IsSsn(string ssn)
        {
            Regex pattern = new Regex(@"^\d{3}-?\d{2}-?\d{4}$");
            if (pattern.IsMatch(ssn))
            {
                return true;
            }
            if(ssn.Length != 9 || string.IsNullOrEmpty(ssn))
            {
                return false;
            }
            int num;
            bool isNum = int.TryParse(ssn, out num);
            if (isNum)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks if a number is within range
        /// </summary>
        /// <param name="numToTest">The number to test</param>
        /// <param name="minValue">The minimum INCLUSIVE range</param>
        /// <param name="maxValue">The maximum INCLUSIVE range</param>
        /// <returns></returns>
        public static bool IsWithinRange(int numToTest, int minValue, int maxValue)
        {
            throw new NotImplementedException();
        }
    }
}
