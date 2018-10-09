using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Conversion.Extract.Validation.Validators
{
    public class NumberValidator : IValidate
    {
        public NumberValidator()
        {

            ValidationError = "Is not a valid number";
            CompareList = new List<string>();
        }

        public bool UseMe(string validatorName)
        {
            return string.Equals("number", validatorName, StringComparison.CurrentCultureIgnoreCase);
        }

        public string ValidationError { get; set; }
        public IList<string> CompareList { get; set; }

        public bool IsValid(string inputValue, string fieldName)
        {
            var alphaTest = new Regex("[A-Za-z]");
            if (alphaTest.IsMatch(inputValue))
            {
                ValidationError = $"{fieldName} - ({inputValue}) - {ValidationError}";
                return false;
            }

            var r = new Regex(@"[1-9]\d*(\.\d+)?$");

            var result = r.IsMatch(inputValue);

            if (!result)
            {
                ValidationError = $"{fieldName} - ({inputValue}) - {ValidationError}";
            }

            return result;
        }
    }
}