using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_MARKETINGTESTRESULT_HIST
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

        [Key]
        [Column(Order = 4, TypeName = "datetime2")]
        public DateTime UPDATEDATE { get; set; }

        public double? RAWSCORE { get; set; }

        [Key]
        [Column(Order = 5)]
        public long SSIS_uniqueID { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_MARKETINGTEST IGEN_MARKETINGTEST { get; set; }

        public virtual IGEN_RESULTMAP IGEN_RESULTMAP { get; set; }

        public virtual IGEN_SAMPLE IGEN_SAMPLE { get; set; }
    }
}
