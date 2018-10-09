using System.Collections.Generic;

namespace Conversion.Extract.Validation.Validators
{
    public interface IValidate
    {
        bool UseMe(string validatorName);
        string ValidationError { get; set; }

        IList<string> CompareList { get; set; }
        bool IsValid(string inputValue, string fieldName);
    }
}