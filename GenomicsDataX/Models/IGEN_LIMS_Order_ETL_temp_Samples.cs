using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_LIMS_Order_ETL_temp_Samples
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iSampleID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iOrganizationID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string sCustomerSampleID { get; set; }

        public short? iSampleTypeID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dExtractionDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dBankedDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dMissingDate { get; set; }

        public short? iSire { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string sBarCode { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string sAnimalID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string sBarCode2 { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int iSpeciesID { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string sBreed { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(100)]
        public string sEarNotch { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(100)]
        public string sRegistrationNumber { get; set; }

        [StringLength(100)]
        public string sMemberCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dDOB { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(255)]
        public string cSex { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(100)]
        public string sDam { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(20)]
        public string sDamAssocCode { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(100)]
        public string sSire1 { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(20)]
        public string sSire1AssocCode { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(100)]
        public string sSire2 { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(20)]
        public string sSire2AssocCode { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(1000)]
        public string sSampleNotes { get; set; }

        public long? iOriginalSampleID { get; set; }

        public long? iFirstOrderID { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(15)]
        public string sSampleStatus { get; set; }

        public long? iExtSampleID { get; set; }

        [StringLength(15)]
        public string sZipCode { get; set; }

        [StringLength(45)]
        public string sSKU { get; set; }

        public int? iInvoiceStatusID { get; set; }

        public long? iExportID { get; set; }

        [StringLength(20)]
        public string sHerdCode { get; set; }

        [StringLength(10)]
        public string sBirthStatus { get; set; }

        [StringLength(40)]
        public string sElectronicID { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iAGLCaseNumber { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iOrderID { get; set; }

        [StringLength(20)]
        public string BREEDASSOCIATIONCODE { get; set; }

        [StringLength(255)]
        public string sBatchID { get; set; }

        [StringLength(30)]
        public string sSampleType { get; set; }
    }
}
