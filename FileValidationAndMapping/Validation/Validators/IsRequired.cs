using System.Collections.Generic;
using System.Text;

namespace FileValidationAndMapping.Validation.Validators
{
    public class IsRequired : IValidate
    {
        public IsRequired()
        {
            ValidationError = "Must be supplied.";
            CompareList = new List<string>();
        }

        public bool UseMe(Utils.Validators validatorName)
        {
            return Utils.Validators.IsRequired == validatorName;
        }

        public string ValidationError { get; set; }
        public string ValidationResults { get; set; }
        public IList<string> CompareList { get; set; }

        public bool IsValid(string inputValue, string fieldName)
        {
            var result = string.IsNullOrEmpty(inputValue);

            if (result)
            {
                ValidationResults =  $"{fieldName} - ({inputValue}) - {ValidationError}";
            }

            return !result;

        }
    }   
}