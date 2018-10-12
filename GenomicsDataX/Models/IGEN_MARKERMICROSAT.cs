using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_MARKERMICROSAT
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MARKER_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string NAME { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_MARKER IGEN_MARKER { get; set; }
    }
}
