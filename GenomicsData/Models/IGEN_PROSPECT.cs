using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_PROSPECT
    {
        [Key]
        public int PROSPECT_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string PROSPECT_TYPE { get; set; }

        [Required]
        [StringLength(40)]
        public string FIRSTNAME { get; set; }

        [Required]
        [StringLength(40)]
        public string LASTNAME { get; set; }

        [StringLength(40)]
        public string OPERATION_NAME { get; set; }

        [StringLength(80)]
        public string ADDRESSLINE1 { get; set; }

        [StringLength(80)]
        public string ADDRESSLINE2 { get; set; }

        [Required]
        [StringLength(40)]
        public string CITY { get; set; }

        [Required]
        [StringLength(20)]
        public string STATE { get; set; }

        [StringLength(20)]
        public string POSTALCODE { get; set; }

        [StringLength(20)]
        public string PHONE { get; set; }

        [Required]
        [StringLength(80)]
        public string EMAIL { get; set; }

        public bool NEWSLETTER_OPT_IN { get; set; }

        [StringLength(100)]
        public string OPERATION_TYPE { get; set; }

        [StringLength(80)]
        public string OTHER { get; set; }

        [StringLength(40)]
        public string BUSINESS_TYPE { get; set; }

        public bool? ALLIANCE_PROGRAM { get; set; }

        public int? BEEF_COWS { get; set; }

        public int? BEEF_HEIFERS { get; set; }

        public int? DAIRY_COWS { get; set; }

        public int? DAIRY_HERD { get; set; }

        public bool? PURCHASE_SEMEN { get; set; }

        public bool? CONVERTED_TO_CUSTOMER { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SUBMIT_DATE { get; set; }

        [StringLength(250)]
        public string COMMENTS { get; set; }

        public DateTime dLastDWUpdate { get; set; }
    }
}
