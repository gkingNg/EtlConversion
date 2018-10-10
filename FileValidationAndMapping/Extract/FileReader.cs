using FileHelpers;
using FileHelpers.Dynamic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

            ClassBuilder(ignoreLines, fieldNames, separator);

            var engine = new FileHelperEngine(InputType);
            var userRecords = engine.ReadFile(filePath);

            return userRecords;

        }

        public IList<object> ReadStream(TextReader fileStream, int ignoreLines, IDictionary<int, string> fieldNames,
            char[] separator)
        {

            ClassBuilder(ignoreLines, fieldNames, separator);

            var engine = new FileHelperEngine(InputType);
            var userRecords = engine.ReadStream(fileStream);

            return userRecords;
        }

        private void ClassBuilder(int ignoreLines, IDictionary<int, string> fieldNames, char[] separator)
        {
            var builder = new DelimitedClassBuilder("UserRecord", separator[0].ToString())
            {
                IgnoreFirstLines = ignoreLines
            };


            foreach (var field in fieldNames.OrderBy(x => x.Key))
            {
                builder.AddField(field.Value, typeof(string));
            }

            InputType = builder.CreateRecordClass();
        }
        /// <summary>
        /// Opens file (filePath) and reads Header line (lineWithHeaders 0 based) and returns list of columns
        /// </summary>
        /// <param name="lineWithHeaders">0 based</param>
        /// <param name="filePath"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public IDictionary<int, string> GetHeaderFieldNamesFromFile(int lineWithHeaders, string filePath, char[] separator)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"{filePath} does not exists");
            }

            var lines = File.ReadLines(filePath).ToList();
            var result = new Dictionary<int, string>();

            var lineParts = lines[lineWithHeaders].Split(separator).ToList();

            for (int i = 0; i < lineParts.Count; i++)
            {
                result.Add(i, lineParts[i].Replace(" ", ""));
            }

            return result;

        }
    }
}