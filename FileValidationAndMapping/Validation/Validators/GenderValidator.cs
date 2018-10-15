using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileValidationAndMapping.Validation.Validators
{
    public class GenderValidator : IValidate
    {
       
        public GenderValidator()
        {
            ValidationError = "is not a valid gender indicator";
            CompareList = new List<string>();
        }
            
        public bool UseMe(Utils.Validators validatorName)
        {
            return Utils.Validators.Gender == validatorName;
        }


        public string ValidationError { get; set; }
        public string ValidationResults { get; set; }
        public IList<string> CompareList { get; set; }

        public bool IsValid(string inputValue, string fieldName)
        {
            var result = CompareList.Contains(inputValue, StringComparer.CurrentCultureIgnoreCase);
            if (!result) ValidationResults = $"{inputValue} - {ValidationError} for {fieldName}";

            return result;
        }

        
    }
}