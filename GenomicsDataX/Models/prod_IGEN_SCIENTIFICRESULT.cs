using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class prod_IGEN_SCIENTIFICRESULT
    {
        [Key]
        [Column(Order = 0)]
        public int SCIENTIFICRESULT_ID { get; set; }

        public int? SCIENTIFICTEST_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int USER_ID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "datetime2")]
        public DateTime DATERECEIVED { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(40)]
        public string BARCODEID { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool MOSTRECENT { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(40)]
        public string REFBARCODEID { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(10)]
        public string RESULTTYPE { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MARKERCOUNT { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SUCCESSCOUNT { get; set; }

        public string RESULT { get; set; }

        public double? PARENTMATCHSUCCESSCOUNT { get; set; }

        [StringLength(250)]
        public string COMMENTS { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime dLastDWUpdate { get; set; }
    }
}
