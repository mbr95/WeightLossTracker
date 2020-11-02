using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WeightLossTracker.Library
{
    public static class FormValidator
    {
        public static bool FirstNameValidation(string firstName)
        {
            string validFirstName = @"^[A-Z][a-z]{1,24}$";
            bool isValid = Regex.IsMatch(firstName, validFirstName);

            return isValid;
        }

        public static bool LastNameValidation(string lastName)
        {
            string validLastName = @"^[A-Z][a-z]{0,24}$";
            bool isValid = Regex.IsMatch(lastName, validLastName);

            return isValid;
        }

        public static bool WeightValidation(string weight)
        {
            string validWeight = @"^\d{1,3}(,\d*)?$";
            bool isValid = Regex.IsMatch(weight, validWeight);

            return isValid;
        }
    }
}
