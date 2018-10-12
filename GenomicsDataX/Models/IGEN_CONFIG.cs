using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_CONFIG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string NAME { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string VALUE { get; set; }

        public int? PRIORITY { get; set; }

        [StringLength(500)]
        public string DESCRIPTION { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime dLastDWUpdate { get; set; }
    }
}
