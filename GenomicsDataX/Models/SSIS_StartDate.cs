using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class SSIS_StartDate
    {
        [Key]
        [Column(Order = 0)]
        public DateTime StartDate { get; set; }

        [Key]
        [Column(Order = 1)]
        public long SSIS_uniqueID { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime dLastDWUpdate { get; set; }
    }
}
