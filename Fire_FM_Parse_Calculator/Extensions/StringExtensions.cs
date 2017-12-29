using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_FM_Parse_Calculator.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Converts the string to a 32-bit integer (converts empty or null strings to 0)
        /// </summary>
        /// <param name="str"></param>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="OverflowException"></exception>
        /// <returns></returns>
        public static int ToInt(this string str)
        {
            return string.IsNullOrEmpty(str) ? 0 : Convert.ToInt32(str);
        }
    }
}
