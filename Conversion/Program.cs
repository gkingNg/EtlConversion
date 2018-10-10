using Conversion.Extract;
using Conversion.Extract.Validation;
using Conversion.Models;
using Conversion.Transform;
using System;
using System.Collections.Generic;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"U:\TestData\DSS.csv";

            var fr = new FileReader();

            char[] separator = { ',' };
            var fieldNames = fr.GetHeaderFieldNames(0, filePath, separator);

            var userRecords = fr.ReadFile(filePath, 1, fieldNames, separator);

            var validatorDefs = new List<ValidatorDef>
            {
                new ValidatorDef("BarcodeId", "IsRequired"),
                new ValidatorDef("AnimalID", "IsRequired"),
                new ValidatorDef("DamRegistrationNumber", "number"),
                new ValidatorDef("SexofAnimal", "Gender","","M,F,Male,Female,sire,dam,heifer,steer"),
            };

            var vproc = new ValidationProcessor(validatorDefs);

            if (! vproc.RunValidatorsForAll(fr.InputType, userRecords))
            {
                Console.WriteLine(vproc.ErrorMessages.ToString());
                EndProgram();
                return;
            };

            var fm = new FileMapper();

            IList<MapDefinition> mapDefs = new List<MapDefinition>();

            mapDefs.Add(new MapDefinition() { InputName = "BarcodeId", OutputName = "BarcodeId" });
            mapDefs.Add(new MapDefinition() { InputName = "AnimalID", OutputName = "AnimalId" });
            mapDefs.Add(new MapDefinition() { InputName = "SexofAnimal", OutputName = "GenderOfAnimal" });
            mapDefs.Add(new MapDefinition() { InputName = "DamRegistrationNumber", OutputName = "DamRegistrationNumber" });

            var output = fm.MapFields<OutPutRow>(userRecords, mapDefs, fr.InputType);

            EndProgram();
        }

        private static void EndProgram()
        {
            Console.WriteLine("... any key to continue ...");
            Console.ReadKey();
        }
    }
}
