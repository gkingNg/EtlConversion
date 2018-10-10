using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_CUSTOMERPROGRAM
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PROGRAMPERIOD_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PROGRAM_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string STATUS { get; set; }

        [Key]
        [Column(Order = 3)]
        public long SSIS_uniqueID { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_CUSTOMERPROGRAMPERIOD IGEN_CUSTOMERPROGRAMPERIOD { get; set; }
    }
}
