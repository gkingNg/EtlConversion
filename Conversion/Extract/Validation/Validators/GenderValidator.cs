using System;
using System.Collections.Generic;
using System.Linq;

namespace Conversion.Extract.Validation.Validators
{
    public class GenderValidator : IValidate
    {

        public GenderValidator()
        {
            ValidationError = "is not a valid gender indicator";
            CompareList = new List<string>();
        }

        public bool UseMe(string validatorName)
        {
            return string.Equals("Gender", validatorName, StringComparison.CurrentCultureIgnoreCase);
        }


        public string ValidationError { get; set; }
        public IList<string> CompareList { get; set; }

        public bool IsValid(string inputValue, string fieldName)
        {
            var result = CompareList.Contains(inputValue, StringComparer.CurrentCultureIgnoreCase);
            if (!result) ValidationError = $"{inputValue} - {ValidationError}";

            return result;
        }

        
    }
}