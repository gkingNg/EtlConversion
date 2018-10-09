using System;
using System.Collections.Generic;

namespace Conversion.Extract.Validation.Validators
{
    public class DateValidator : IValidate
    {
        public DateValidator()
        {
            ValidationError = "Is not a valid date";
            CompareList =new List<string>();
        }

        public bool UseMe(string validatorName)
        {
            return string.Equals("Date", validatorName, StringComparison.CurrentCultureIgnoreCase);
        }

        public string ValidationError { get; set; }
        public IList<string> CompareList { get; set; }

        public bool IsValid(string inputValue, string fieldName)
        {
            DateTime result;
            var temp =  DateTime.TryParse(inputValue, out result);
            if (!temp)
            {
                ValidationError = $"{fieldName} - ({inputValue}) - {ValidationError}";
            }

            return temp;

        }
    }
}