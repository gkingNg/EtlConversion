using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class SSIS_TableColumnTrigger_Log
    {
        [Key]
        [Column(Order = 0)]
        public int UniqueID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(2000)]
        public string Description { get; set; }

        public string SQLText { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime LogDate { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime dLastDWUpdate { get; set; }
    }
}
