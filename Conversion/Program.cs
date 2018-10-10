
using System;
using System.Collections.Generic;
using System.IO;
using FileValidationAndMapping.Extract;
using FileValidationAndMapping.Extract.Validation;
using FileValidationAndMapping.Models;
using FileValidationAndMapping.Transform;


namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filePath = @"U:\TestData\DSS.csv";

            var fileReader = new FileReader();

            char[] separator = { ',' };
            var fieldNames = fileReader.GetHeaderFieldNamesFromFile(0, filePath, separator);

            //var userRecords = fileReader.ReadFile(filePath, 1, fieldNames, separator);
            var stream = File.OpenText(filePath);
            var userRecords = fileReader.ReadStream(stream, 1, fieldNames, separator);

            var validatorDefs = new List<ValidatorDef>
            {
                new ValidatorDef("BarcodeId", "IsRequired"),
                new ValidatorDef("AnimalID", "IsRequired"),
                new ValidatorDef("DamRegistrationNumber", "number"),
                new ValidatorDef("SexofAnimal", "Gender","","M,F,Male,Female,sire,dam,heifer,steer"),
            };

            var validationProcessor = new ValidationProcessor(validatorDefs);

            if (! validationProcessor.RunValidatorsForAll(fileReader.InputType, userRecords))
            {
                Console.WriteLine(validationProcessor.ErrorMessages.ToString());
                EndProgram();
                return;
            }

            var fileMapper = new FileMapper();

            IList<MapDefinition> mapDefs = new List<MapDefinition>();

            mapDefs.Add(new MapDefinition() { InputName = "BarcodeId", OutputName = "BarcodeId" });
            mapDefs.Add(new MapDefinition() { InputName = "AnimalID", OutputName = "AnimalId" });
            mapDefs.Add(new MapDefinition() { InputName = "SexofAnimal", OutputName = "GenderOfAnimal" });
            mapDefs.Add(new MapDefinition() { InputName = "DamRegistrationNumber", OutputName = "DamRegistrationNumber" });

            var output = fileMapper.MapFields<OutPutRow>(userRecords, mapDefs, fileReader.InputType);

            EndProgram();
        }

        private static void EndProgram()
        {
            Console.WriteLine("");
            Console.WriteLine("**** End of Program ****");
            Console.WriteLine("... any key to continue ...");
            Console.ReadKey();
        }
    }
}
