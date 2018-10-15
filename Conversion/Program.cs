
using System;
using System.Collections.Generic;
using System.IO;
using FileValidationAndMapping.Extract;
using FileValidationAndMapping.Models;
using FileValidationAndMapping.Transform;
using FileValidationAndMapping.Validation;


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
            var ignoreLines = 1;
            var userRecords = fileReader.ReadStream(stream, ignoreLines, fieldNames, separator);


            //These will come from database
            var validatorDefs = new List<ValidatorDef>
            {
                new ValidatorDef("BarcodeId", "IsRequired"),
                new ValidatorDef("AnimalID", "IsRequired"),
                new ValidatorDef("DamRegistrationNumber", "number"),
                new ValidatorDef("SexofAnimal", "Gender","","m,F,Male,Female,sire,dam,heifer,steer"),
            };

            var validationProcessor = new ValidationProcessor(validatorDefs);

            if (! validationProcessor.RunValidatorsForAllObjects(fileReader.InputType, userRecords))
            {
                Console.WriteLine(validationProcessor.ErrorMessages.ToString());
                EndProgram();
                return;
            }

            var fileMapper = new FileMapper();


            //These will come from database
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
