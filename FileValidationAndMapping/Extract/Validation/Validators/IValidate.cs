using System.Collections.Generic;

namespace FileValidationAndMapping.Extract.Validation.Validators
{
    public interface IValidate
    {
        bool UseMe(Utils.Validators validatorName);
        string ValidationError { get; set; }

        IList<string> CompareList { get; set; }
        bool IsValid(string inputValue, string fieldName);
    }
}