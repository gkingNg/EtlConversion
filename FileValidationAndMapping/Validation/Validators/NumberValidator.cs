using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FileValidationAndMapping.Validation.Validators
{
    public class NumberValidator : IValidate
    {
        public NumberValidator()
        {
            ValidationError = "Is not a valid number";
            CompareList = new List<string>();
        }

        public bool UseMe(Utils.Validators validatorName)
        {
            return Utils.Validators.Number == validatorName;
        }

        public string ValidationError { get; set; }
        public string ValidationResults { get; set; }
        public IList<string> CompareList { get; set; }

        public bool IsValid(string inputValue, string fieldName)
        {
            var alphaTest = new Regex("[A-Za-z]");
            if (alphaTest.IsMatch(inputValue))
            {
                ValidationResults = $"{fieldName} - ({inputValue}) - {ValidationError}";
                return false;
            }

            var r = new Regex(@"[1-9]\d*(\.\d+)?$");

            var result = r.IsMatch(inputValue);

            if (!result)
            {
                ValidationResults =  $"{fieldName} - ({inputValue}) - {ValidationError}";
            }

            return result;
        }
    }
}