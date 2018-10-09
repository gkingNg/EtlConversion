using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Conversion.Extract.Validation.Validators;
using Conversion.Utils;

namespace Conversion.Extract.Validation
{
    public class ValidationProcessor
    {
        private readonly IList<ValidatorDef> _validatorDefs;
        private readonly IList<IValidate> _validatorList;


        public ValidationProcessor(IList<ValidatorDef> validatorDefs)
        {
            ErrorMessages = new StringBuilder();
            _validatorDefs = validatorDefs;
            _validatorList = new List<IValidate>();

            InitializeValidators();
        }

        public StringBuilder ErrorMessages { get; set; }
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

        public bool RunValidators(Type myType, object test)
        {
            bool isValid = true;
            var methods = myType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            foreach (var val in _validatorDefs)
            {
                var m = methods.FirstOrDefault(x =>
                    string.Equals(x.Name, val.FieldName, StringComparison.CurrentCultureIgnoreCase));

                if (m == null)
                {
                    ErrorMessages.AppendLine($"{val.FieldName} does not exist");
                    continue;
                }

                var value = m.GetValue(test);

                var validator = _validatorList.FirstOrDefault(x => x.UseMe(val.ValidatorToUse)) ?? new DefaultValidator();

                if (!string.IsNullOrEmpty(val.ErrorMessage)) validator.ValidationError = val.ErrorMessage;
                if (!string.IsNullOrEmpty(val.CompareList)) validator.CompareList = val.CompareList.Split(',');

                if (!validator.IsValid(value.SafeToString(), val.FieldName))
                {
                    ErrorMessages.AppendLine(validator.ValidationError);
                    isValid = false;
                }
            }

            return isValid;
        }
    }
}