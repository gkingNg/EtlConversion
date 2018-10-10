using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_NMBREEDPERCENTILERANGE
    {
        [Key]
        [Column(Order = 0)]
        public int PERCENTILERANGE_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string BREED { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string SEX { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DECILE { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PERCENTILE { get; set; }

        public double? RANGEVALUE { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime RANGEDATE { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime dLastDWUpdate { get; set; }
    }
}
