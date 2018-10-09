﻿using Conversion.Extract;
using Conversion.Extract.Validation;
using Conversion.Transform;
using System;
using System.Collections.Generic;
using System.Linq;

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


            //IDictionary<int, string> fieldNames = new Dictionary<int, string>();
            //fieldNames.Add(1, "BarcodeId");
            //fieldNames.Add(2, "AnimalID");
            //fieldNames.Add(3, "SexofAnimal");
            //fieldNames.Add(4, "ElectronicID");
            //fieldNames.Add(5, "Comments");
            //fieldNames.Add(6, "RequiresCDCBEvaluation");
            //fieldNames.Add(7, "SireRegistrationNumber");
            //fieldNames.Add(8, "SireID");
            //fieldNames.Add(9, "DamRegistrationNumber");
            //fieldNames.Add(10, "DamID");
            //fieldNames.Add(11, "SampleType");
            //fieldNames.Add(12, "CaseNumber");
            //fieldNames.Add(13, "BatchNumber");
            //fieldNames.Add(14, "OriginalSampleID");
            //fieldNames.Add(15, "RegistrationNumber");
            //fieldNames.Add(16, "Breed1");
            //fieldNames.Add(17, "Breed2");
            //fieldNames.Add(18, "BreedingGroup");
            //fieldNames.Add(19, "BirthDate");
            //fieldNames.Add(20, "AnimalID2");
            //fieldNames.Add(21, "BirthStatus");
            //fieldNames.Add(22, "BreedingAssociationCode");
            //fieldNames.Add(23, "MemberNumber");
            //fieldNames.Add(24, "Quantity");
            //fieldNames.Add(25, "Test");
            //fieldNames.Add(26, "TestDescription");


            var userRecords = fr.ReadFile(filePath, 1, fieldNames, separator);

            var validatorDefs = new List<ValidatorDef>
            {
                new ValidatorDef("BarcodeId", "IsRequired"),
                new ValidatorDef("AnimalID", "IsRequired"),
                new ValidatorDef("DamRegistrationNumber", "number"),
                new ValidatorDef("SexofAnimal", "Gender","","M,F,Male,Female,sire,dam,heifer,steer"),
            };

            var vproc = new ValidationProcessor(validatorDefs);
            var isValid = new List<bool>();


            foreach (var record in userRecords)
            {
                isValid.Add(vproc.RunValidators(fr.InputType, record));
            }

            if (isValid.Any(x => x == false))
            {
                Console.WriteLine(vproc.ErrorMessages.ToString());
                return;
            }

            var fm = new FileMapper();

            IList<MapDefinition> mapDefs = new List<MapDefinition>();

            mapDefs.Add(new MapDefinition() { InputName = "BarcodeId",  OutputName = "BarcodeId" });
            mapDefs.Add(new MapDefinition() { InputName = "AnimalID",OutputName = "AnimalId"});
            mapDefs.Add(new MapDefinition() { InputName = "SexofAnimal",  OutputName = "GenderOfAnimal" });
            mapDefs.Add(new MapDefinition() { InputName = "DamRegistrationNumber",OutputName = "DamRegistrationNumber" });


            var output = fm.Map<OutPutRow>(userRecords, mapDefs, fr.InputType);

            Console.WriteLine("... any key to continue ...");
            Console.ReadKey();

        }
    }
}
