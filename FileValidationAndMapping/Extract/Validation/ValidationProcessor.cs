using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using FileValidationAndMapping.Extract.Validation.Validators;
using FileValidationAndMapping.Utils;

namespace FileValidationAndMapping.Extract.Validation
{
    public class ValidationProcessor
    {
        private readonly IList<ValidatorDef> _validatorDefs;
        private readonly IList<IValidate> _validatorList;

        public ValidationProcessor(IList<ValidatorDef> validatorDefs)
        {
            _validatorDefs = validatorDefs;
            ErrorMessages = new StringBuilder();
            _validatorList = new List<IValidate>();

            InitializeValidators();
        }
        /// <summary>
        /// Takes in 2 lists to compare
        /// </summary>
        /// <param name="expectedHeaders"></param>
        /// <param name="actualHeaders"></param>
        /// <returns>Bool</returns>
        public bool HeaderValidation(IList<string> expectedHeaders, IList<string> actualHeaders)
        {
            bool isValid = true;

           var diffs = expectedHeaders.Except(actualHeaders).ToList();

            if (diffs.Any())
            {
                isValid = false;
                ErrorMessages.AppendLine("Missing Columns - ");
                ErrorMessages.AppendLine(string.Join(", ",diffs));
            }

            return isValid;
        }
        /// <summary>
        /// Return for all validation errors in current run
        /// </summary>
        public StringBuilder ErrorMessages { get; set; }
        /// <summary>
        /// Runs all defined validations for all objects in input userObjects
        /// </summary>
        /// <param name="myType">Type of input object</param>
        /// <param name="userObjects">Single object to be validated</param>
        /// <returns></returns>
        public bool RunValidatorsForAll(Type myType, IList<object> userObjects)
        {
            var isValidList = userObjects.Select(obj => RunValidators(myType, obj)).ToList();

            return isValidList.TrueForAll(x => x);

        }
        /// <summary>
        /// Runs all defined validations for userObject
        /// </summary>
        /// <param name="myType">Type of input object</param>
        /// <param name="userObject">Single object to be validated</param>
        /// <returns></returns>
        public bool RunValidators(Type myType, object userObject)
        {
            bool isValid = true;
            var methods = myType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            foreach (var val in _validatorDefs)
            {
                var m = methods.FirstOrDefault(x =>
                    string.Equals(x.Name, val.FieldName, StringComparison.CurrentCultureIgnoreCase));

                if (m == null)
                {
                    ErrorMessages.AppendLine($"Column for ({val.FieldName}) is not in current row");
                    isValid = false;
                    continue;
                }

                var value = m.GetValue(userObject);

                var validatorToUse = val.ValidatorToUse.ParseEnum<Utils.Validators>();
                var validator = _validatorList.FirstOrDefault(x => x.UseMe(validatorToUse)) ?? new DefaultValidator();

                if (!string.IsNullOrEmpty(val.ErrorMessage)) validator.ValidationError = val.ErrorMessage;
                if (!string.IsNullOrEmpty(val.CompareList)) validator.CompareList = val.CompareList.Split(',');

                if (validator.IsValid(value.SafeToString(), val.FieldName)) continue;

                ErrorMessages.AppendLine(validator.ValidationError);
                isValid = false;
            }

            return isValid;
        }

        private void InitializeValidators()
        {
            var interfaceType = typeof(IValidate);
            var all = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => interfaceType.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(Activator.CreateInstance);

            foreach (var v in all)
            {
                _validatorList.Add((IValidate)v);
            }
        }
    }
}