using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_LIMS_Order_ETL_temp_SamplesInLineItems
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iSampleInLineItemID { get; set; }

        public long? iSampleID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iLineItemID { get; set; }

        [StringLength(255)]
        public string sBatchID { get; set; }

        [StringLength(255)]
        public string sCustomerTestID { get; set; }

        [StringLength(255)]
        public string sRemark { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string sSTStatus { get; set; }

        [StringLength(5000)]
        public string sResult { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int iSuccessMarkerCount { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int iFailMarkerCount { get; set; }

        public long? iSLInvoiceID { get; set; }

        public long? iLIMSInvoiceID { get; set; }

        public bool? iParentagePending { get; set; }

        public bool? iActive { get; set; }

        public DateTime? dParentageRun { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool iUpdateCustomer { get; set; }

        [StringLength(45)]
        public string sSKU { get; set; }

        public int? iInvoiceStatusID { get; set; }

        public long? iExportID { get; set; }
    }
}
