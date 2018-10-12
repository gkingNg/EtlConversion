using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_ORDERKIT
    {
        [Key]
        public int ORDERKIT_ID { get; set; }

        [Required]
        [StringLength(40)]
        public string COLLECTOR_TYPE { get; set; }

        public int? COLLECTORS_COUNT { get; set; }

        public int? APPLICATORS_COUNT { get; set; }

        public int? REPLACEMENTPINS_COUNT { get; set; }

        public bool? OVERNIGHT_SHIPPING { get; set; }

        public double? CREDIT_AMOUNT { get; set; }

        [Required]
        [StringLength(40)]
        public string OPERATION_NAME { get; set; }

        [Required]
        [StringLength(40)]
        public string LASTNAME { get; set; }

        [Required]
        [StringLength(40)]
        public string FIRSTNAME { get; set; }

        [Required]
        [StringLength(20)]
        public string PHONE { get; set; }

        [StringLength(20)]
        public string FAX { get; set; }

        [Required]
        [StringLength(80)]
        public string SUBMITTER_EMAIL { get; set; }

        [Required]
        [StringLength(80)]
        public string SHIP_ADDRESS1 { get; set; }

        [StringLength(80)]
        public string SHIP_ADDRESS2 { get; set; }

        [Required]
        [StringLength(40)]
        public string SHIP_CITY { get; set; }

        [Required]
        [StringLength(20)]
        public string SHIP_STATE { get; set; }

        [Required]
        [StringLength(20)]
        public string SHIP_POSTALCODE { get; set; }

        [Required]
        [StringLength(20)]
        public string SHIP_COUNTRY { get; set; }

        [StringLength(80)]
        public string BILL_ADDRESS1 { get; set; }

        [StringLength(80)]
        public string BILL_ADDRESS2 { get; set; }

        [StringLength(40)]
        public string BILL_CITY { get; set; }

        [StringLength(20)]
        public string BILL_STATE { get; set; }

        [StringLength(20)]
        public string BILL_POSTALCODE { get; set; }

        [StringLength(20)]
        public string BILL_COUNTRY { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SUBMIT_DATE { get; set; }

        public DateTime dLastDWUpdate { get; set; }
    }
}
