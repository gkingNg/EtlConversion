using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using FileHelpers;
using FileHelpers.Dynamic;

namespace FileValidationAndMapping.Extract
{
    public class FileReader
    {
        public Type InputType { get; set; }
        public IList<object> ReadFile(string filePath, int ignoreLines, IDictionary<int, string> fieldNames,
            char[] separator)
        {

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"{filePath} does not exists");
            }

            var builder = new DelimitedClassBuilder("UserRecord", separator[0].ToString())
            {
                IgnoreFirstLines = ignoreLines
            };


            foreach (var field in fieldNames.OrderBy(x => x.Key))
            {
                builder.AddField(field.Value, typeof(string));
            }

            InputType = builder.CreateRecordClass();

            var engine = new FileHelperEngine(InputType);
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

        public IDictionary<int, string> GetHeaderFieldNames(int lineInFileWithHeaders, string filePath, char[] separator)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"{filePath} does not exists");
            }

            var lines = File.ReadLines(filePath).ToList();
            var result = new Dictionary<int, string>();

            var lineParts = lines[lineInFileWithHeaders].Split(separator).ToList();

            for (int i = 0; i < lineParts.Count; i++)
            {
                result.Add(i, lineParts[i].Replace(" ", ""));
            }

            return result;

        }
    }
}