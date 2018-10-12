using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_RESULTMAPRESULTMARKER
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MARKER_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RESULTMAPRESULT_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string MARKERVALUEA1 { get; set; }

        [Required]
        [StringLength(10)]
        public string MARKERVALUEA2 { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_MARKER IGEN_MARKER { get; set; }

        public virtual IGEN_RESULTMAPRESULT IGEN_RESULTMAPRESULT { get; set; }
    }
}
