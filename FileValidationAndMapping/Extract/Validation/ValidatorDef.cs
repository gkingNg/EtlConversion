namespace FileValidationAndMapping.Extract.Validation
{
    public class ValidatorDef
    {
        public ValidatorDef(string fieldName, string validatorToUse)
        {
            FieldName = fieldName;
            ValidatorToUse = validatorToUse;
        }

        public ValidatorDef(string fieldName, string validatorToUse, string errorMessage, string compareList)
        {
            FieldName = fieldName;
            ValidatorToUse = validatorToUse;
            ErrorMessage = errorMessage;
            CompareList = compareList;
        }

        public string FieldName { get; set; }
        public string ValidatorToUse { get; set; }
        public string ErrorMessage { get; set; }
        public string CompareList { get; set; }
    }
}