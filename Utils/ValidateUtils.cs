using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace prj_LTTQ_BTL.Utils
{
    internal class ValidateUtils
    {
        public static bool IsNotEmpty(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            string phonePattern = @"^\d{10,15}$";
            return Regex.IsMatch(phoneNumber, phonePattern);
        }

        public static bool IsValidBirthDate(DateTime birthDate)
        {
            return birthDate <= DateTime.Now;
        }

        public static bool IsValidLength(string input, int minLength, int maxLength)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            return input.Length >= minLength && input.Length <= maxLength;
        }
        public static bool IsValidScore(float score)
        {
            return score >= 0 && score <= 10;
        }
    }
}
