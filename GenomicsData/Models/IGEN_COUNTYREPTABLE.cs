using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_COUNTYREPTABLE
    {
        [StringLength(50)]
        public string COUNTYNAME { get; set; }

        [StringLength(50)]
        public string STATE { get; set; }

        [StringLength(50)]
        public string REP { get; set; }

        [Key]
        [Column(Order = 0)]
        public long SSIS_uniqueID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime dLastDWUpdate { get; set; }
    }
}
