using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_SAMPLELABETA
    {
        [Key]
        public int SAMPLEETA_ID { get; set; }

        public int LAB_ORDERID { get; set; }

        public int LAB_SAMPLEID { get; set; }

        public int? LAB_ID { get; set; }

        [Required]
        [StringLength(40)]
        public string BARCODEID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? SUBMIT_DATE { get; set; }

        [StringLength(100)]
        public string SUBMITTED_BY { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? RECEIVED_DATE { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ETA_DATE { get; set; }

        [StringLength(45)]
        public string STAGE { get; set; }

        [StringLength(500)]
        public string COMMENTS { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_LAB IGEN_LAB { get; set; }
    }
}
