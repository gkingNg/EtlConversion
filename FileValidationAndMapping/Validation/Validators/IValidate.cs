using System.Collections.Generic;
using System.Text;

namespace FileValidationAndMapping.Validation.Validators
{
    public interface IValidate
    {
        bool UseMe(Utils.Validators validatorName);
        string ValidationError { get; set; }
        string ValidationResults { get; set; }
        IList<string> CompareList { get; set; }
        bool IsValid(string inputValue, string fieldName);
    }
}