using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_MARKETINGINDEXTESTMAP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MARKETINGINDEXPERIOD_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MARKETINGTEST_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string MAPTYPE { get; set; }

        public int? WEIGHT { get; set; }

        [StringLength(40)]
        public string ALIAS { get; set; }

        [Key]
        [Column(Order = 3)]
        public long SSIS_uniqueID { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_MARKETINGINDEXPERIOD IGEN_MARKETINGINDEXPERIOD { get; set; }

        public virtual IGEN_MARKETINGTEST IGEN_MARKETINGTEST { get; set; }
    }
}
