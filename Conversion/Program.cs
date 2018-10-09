using System;
using System.Collections.Generic;
using System.Linq;
using Conversion.Extract;
using Conversion.Extract.Validation;

namespace Conversion
{
    class Program
    {
        private Type _type;

        static void Main(string[] args)
        {
            var fr = new FileReader();
            var filePath = @"U:\TestData\DSS.csv";
            IDictionary<int, string> fieldNames = new Dictionary<int, string>();

            fieldNames.Add(1, "BarcodeId");
            fieldNames.Add(2, "AnimalID");
            fieldNames.Add(3, "SexofAnimal");
            fieldNames.Add(4, "ElectronicID");
            fieldNames.Add(5, "Comments");
            fieldNames.Add(6, "RequiresCDCBEvaluation");
            fieldNames.Add(7, "SireRegistrationNumber");
            fieldNames.Add(8, "SireID");
            fieldNames.Add(9, "DamRegistrationNumber");
            fieldNames.Add(10, "DamID");
            fieldNames.Add(11, "SampleType");
            fieldNames.Add(12, "CaseNumber");
            fieldNames.Add(13, "BatchNumber");
            fieldNames.Add(14, "OriginalSampleID");
            fieldNames.Add(15, "RegistrationNumber");
            fieldNames.Add(16, "Breed1");
            fieldNames.Add(17, "Breed2");
            fieldNames.Add(18, "BreedingGroup");
            fieldNames.Add(19, "BirthDate");
            fieldNames.Add(20, "AnimalID2");
            fieldNames.Add(21, "BirthStatus");
            fieldNames.Add(22, "BreedingAssociationCode");
            fieldNames.Add(23, "MemberNumber");
            fieldNames.Add(24, "Quantity");
            fieldNames.Add(25, "Test");
            fieldNames.Add(26, "TestDescription");

            var userRecords = fr.ReadFile(filePath, 1, fieldNames);

            var validatorDefs = new List<ValidatorDef>
            {
                new ValidatorDef("BarcodeId", "IsRequired"),
                new ValidatorDef("AnimalID", "IsRequired"),
                new ValidatorDef("SexofAnimal", "Gender","","M,F,Male,Female,sire,dam,heifer,steer"),
            };

            var vproc = new ValidationProcessor(validatorDefs);
            var isValid = new List<bool>();


            foreach (var record in userRecords)
            {
                isValid.Add(vproc.RunValidators(fr.UserType, record));
            }

            if (isValid.Any(x => x == false))
            {
                Console.WriteLine(vproc.ErrorMessages.ToString());
            }

            Console.WriteLine("... any key to continue ...");
            Console.ReadKey();

        }
    }
}
