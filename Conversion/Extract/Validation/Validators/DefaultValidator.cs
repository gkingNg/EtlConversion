using System.Collections.Generic;

namespace Conversion.Extract.Validation.Validators
{
    public class DefaultValidator : IValidate

    {
        public DefaultValidator()
        {
            ValidationError = "Requested validator does not exist";
        }

        public bool UseMe(Utils.Validators validatorName)
        {
            return false;
        }

        public string ValidationError { get; set; }
        public IList<string> CompareList { get; set; }

        public bool IsValid(string inputValue, string fieldName)
        {
            return false;
        }
    }
}