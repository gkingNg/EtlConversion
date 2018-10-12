using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_SCIENTIFICRESULT
    {
        [Key]
        [Column(Order = 0)]
        public int SCIENTIFICRESULT_ID { get; set; }

        public int? SCIENTIFICTEST_ID { get; set; }

        public int USER_ID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DATERECEIVED { get; set; }

        [Required]
        [StringLength(40)]
        public string BARCODEID { get; set; }

        public bool MOSTRECENT { get; set; }

        [Required]
        [StringLength(40)]
        public string REFBARCODEID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string RESULTTYPE { get; set; }

        public int MARKERCOUNT { get; set; }

        public int SUCCESSCOUNT { get; set; }

        public string RESULT { get; set; }

        public double? PARENTMATCHSUCCESSCOUNT { get; set; }

        [StringLength(250)]
        public string COMMENTS { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_SCIENTIFICTEST IGEN_SCIENTIFICTEST { get; set; }

        public virtual IGEN_USER IGEN_USER { get; set; }
    }
}
