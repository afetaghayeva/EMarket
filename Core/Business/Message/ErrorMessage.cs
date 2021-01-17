using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business.Message
{
    public static class ErrorMessage
    {
        public static string GreaterThanZeroMessage = "Your input should be greater than 0";
        public static string GreaterThanZeroOrEqual = "Your input should be greater than or equal 0";
        public static string NullProductErrorMessage = "Please select product";

        public static string LengthMessage(int min, int max)
        {
            return String.Format($"Your input should be between {min} and {max} character");
        }
        public static string ExclusiveBetween(int min, int max)
        {
            return "Your input must be between" + min + "and" + max;
        }

    }
}
