using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_IMPORTLOG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string IMPORT_AREA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string KEY_NAME { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(40)]
        public string KEY_VALUE { get; set; }

        [StringLength(255)]
        public string LOG_MESSAGE { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "datetime2")]
        public DateTime TIMESTAMP { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string STATUS { get; set; }

        [Key]
        [Column(Order = 5)]
        public long SSIS_uniqueID { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime dLastDWUpdate { get; set; }
    }
}
