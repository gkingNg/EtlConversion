using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileValidationAndMapping.Validation.Validators
{
    public class NumberRangeValidator : IValidate
    {
        public NumberRangeValidator()
        {
            ValidationError = " is not between ";
            CompareList  = new List<string>();
        }

        public bool UseMe(Utils.Validators validatorName)
        {
            return Utils.Validators.NumberRange == validatorName;
           
        }

        public string ValidationError { get; set; }
        public string ValidationResults { get; set; }
        public IList<string> CompareList { get; set; }

        public bool IsValid(string inputValue, string fieldName)
        {
            var uLimit = Convert.ToDecimal( CompareList.First());
            var lLimit = Convert.ToDecimal( CompareList.Last());
            var val = Convert.ToDecimal(inputValue);

            var result = val >= lLimit && val <= uLimit;
            if (!result)
            {
                ValidationResults = $"{fieldName} - ({inputValue}) - {ValidationError} {lLimit} and {uLimit}";
            }

            return result;
        }
    }
}