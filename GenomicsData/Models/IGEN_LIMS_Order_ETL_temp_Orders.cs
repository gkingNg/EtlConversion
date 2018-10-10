using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_LIMS_Order_ETL_temp_Orders
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iOrderID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iOrganizationID { get; set; }

        public int? iNSamples { get; set; }

        public DateTime? dOrderCreationDate { get; set; }

        public DateTime? dReceiveDate { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string sBillable { get; set; }

        [StringLength(1024)]
        public string sOrderNotes { get; set; }

        public long? iSubmitterID { get; set; }

        [Column(TypeName = "text")]
        public string sLabNotes { get; set; }

        public DateTime? dETA { get; set; }

        [StringLength(255)]
        public string sCustomerPO { get; set; }

        public DateTime? dClientSubmitDate { get; set; }

        public DateTime? dCompletionDate { get; set; }

        public decimal? nTotalBilledAmount { get; set; }

        public int? iSalesRepID { get; set; }

        public long? iCustomerRepID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string sClosed { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string sShipToID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(200)]
        public string sEndCustomer { get; set; }

        public long? iExtOrderID { get; set; }

        public int? iFirstOrderID { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(3)]
        public string sHold { get; set; }

        public int? iIgenityOrderID { get; set; }

        [StringLength(20)]
        public string sSLOrderNumber { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iAGLBatchId { get; set; }

        [StringLength(10)]
        public string sNeoGenShortName { get; set; }

        public bool? OrderHasAnError { get; set; }

        public int? CUSTOMER_ID { get; set; }

        [StringLength(50)]
        public string sOrgName { get; set; }
    }
}
