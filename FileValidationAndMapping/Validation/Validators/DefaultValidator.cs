using System.Collections.Generic;
using System.Text;

namespace FileValidationAndMapping.Validation.Validators
{
    public class DefaultValidator : IValidate

    {
        public DefaultValidator()
        {
            ValidationError = "Requested validator does not exist";
            ValidationResults = ValidationError;
        }

        public bool UseMe(Utils.Validators validatorName)
        {
            return false;
        }

        public string ValidationError { get; set; }
        public string ValidationResults { get; set; }
        public IList<string> CompareList { get; set; }

        public bool IsValid(string inputValue, string fieldName)
        {
            return false;
        }
    }
}