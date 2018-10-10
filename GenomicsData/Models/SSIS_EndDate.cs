using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class SSIS_EndDate
    {
        [Key]
        [Column(Order = 0)]
        public DateTime EndDate { get; set; }

        [Key]
        [Column(Order = 1)]
        public long SSIS_uniqueID { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime dLastDWUpdate { get; set; }
    }
}
