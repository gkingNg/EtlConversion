using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class igen_markeingtestresult_dfp03132018
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SAMPLE_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MARKETINGTEST_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string MARKETINGRESULT { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CONFIDENCE { get; set; }

        [StringLength(40)]
        public string GENOTYPE { get; set; }

        public int? RESULTMAP_ID { get; set; }

        public double? EFFECT { get; set; }

        public bool? LOCKED { get; set; }

        public double? RAWSCORE { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime dLastDWUpdate { get; set; }
    }
}
