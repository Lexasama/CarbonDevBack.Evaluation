using System;

namespace Leap
{
    public static class Leap
    {
        /// <summary>
        /// Indique si l'année est une année bissextile ou non.
        /// <para>Dans le calendrier grégorien une année bissextile respecte les conditions suivantes :
        /// <br/>- Toutes les années qui sont divisibles par 4
        /// <br/>- à l'exception des années qui sont divisibles par 100
        /// <br/>- sauf si l'année est ausi divisible par 400
        /// </para>
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static bool IsLeapYear(int year)
        {
            return !(year % 4 != 0 || (year % 100 == 0 && year % 400 != 0));
        }
    }
}
