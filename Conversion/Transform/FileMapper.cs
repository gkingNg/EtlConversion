using System;
using System.Collections.Generic;
using System.Linq;

namespace Conversion.Transform
{
    public class FileMapper
    {
        public IList<T> Map<T>(IList<object> inputList, IList<MapDefinition> mapDefinitions, Type userType)
            where T : new()
        {
            IList<T> result = new List<T>();

            for (int i = 0; i < inputList.Count; i++)
            {
                var input = inputList[i];
                var inputFields = userType.GetFields();
                var output = new T();

                foreach (var def in mapDefinitions)
                {
                    var inputValue = inputFields.FirstOrDefault(x => string.Equals(x.Name, def.InputName, StringComparison.CurrentCultureIgnoreCase))?.GetValue(input);

                    var outputProp = typeof(T).GetProperties().FirstOrDefault(x => string.Equals(x.Name, def.OutputName, StringComparison.CurrentCultureIgnoreCase));
                    outputProp?.SetValue(output, inputValue);

                }

                result.Add(output);
            }

            return result;
        }
    }
}