using FileHelpers;

namespace Conversion.Models
{
    [DelimitedRecord(",")]
    public class DairyFileTemplate
    {
        public string BarcodeId;
        public string AnimalID;
        public string SexofAnimal;
        public string ElectronicID;
        public string Comments;
        public string RequiresCDCBEvaluation;
        public string SireRegistrationNumber;
        public string SireID;
        public string DamRegistrationNumber;
        public string DamID;
        public string SampleType;
        public string CaseNumber;
        public string BatchNumber;
        public string OriginalSampleID;
        public string RegistrationNumber;
        public string Breed1;
        public string Breed2;
        public string BreedingGroup;
        public string BirthDate;
        public string AnimalID2;
        public string BirthStatus;
        public string BreedingAssociationCode;
        public string MemberNumber;
        public string Quantity;
        public string Test;
        public string TestDescription;

    }
}