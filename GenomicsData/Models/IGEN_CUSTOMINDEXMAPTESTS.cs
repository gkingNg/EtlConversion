using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_CUSTOMINDEXMAPTESTS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CUSTOMINDEXMAP_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string MAPTYPE { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MARKETINGTEST_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        public long SSIS_uniqueID { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime dLastDWUpdate { get; set; }
    }
}
