using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_SIREEXCLUDEDMARKER
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int POTENTIALSIRE_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string EXCLUSION_TYPE { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MARKER_ID { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_MARKER IGEN_MARKER { get; set; }

        public virtual IGEN_POTENTIALSIRE IGEN_POTENTIALSIRE { get; set; }
    }
}
