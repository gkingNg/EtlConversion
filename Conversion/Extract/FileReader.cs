using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FileHelpers;
using FileHelpers.Dynamic;

namespace Conversion.Extract
{
    public class FileReader
    {
        public Type UserType { get; set; }
        public IList<object> ReadFile(string filePath, int ignoreLines, IDictionary<int, string> fieldNames)
        {
            var builder = new DelimitedClassBuilder("UserRecord", ",");

            builder.IgnoreFirstLines = ignoreLines;

            foreach (var field in fieldNames.OrderBy(x => x.Key))
            {
                builder.AddField(field.Value, typeof(string));
            }

            UserType = builder.CreateRecordClass();

            var engine = new FileHelperEngine(UserType);
            var userRecords = engine.ReadFile(filePath);

            foreach (var o in userRecords)
            {
                var fields = o.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

                foreach (var field in fields)
                {
                    var name = field.Name;
                    var temp = field.GetValue(o);

                    Console.WriteLine($"{name} has a value of {temp}");
                }

            }

            return userRecords;

        }
    }
}