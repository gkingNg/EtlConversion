using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_RESULTEFFECTMARKER
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RESULTEFFECT_ID { get; set; }

        public double ACCURACY { get; set; }

        [Required]
        [StringLength(10)]
        public string GENOTYPE1VALUEA1 { get; set; }

        [Required]
        [StringLength(10)]
        public string GENOTYPE1VALUEA2 { get; set; }

        public double EFFECT1 { get; set; }

        [Required]
        [StringLength(10)]
        public string GENOTYPE2VALUEA1 { get; set; }

        [Required]
        [StringLength(10)]
        public string GENOTYPE2VALUEA2 { get; set; }

        public double EFFECT2 { get; set; }

        [Required]
        [StringLength(10)]
        public string GENOTYPE3VALUEA1 { get; set; }

        [Required]
        [StringLength(10)]
        public string GENOTYPE3VALUEA2 { get; set; }

        public double EFFECT3 { get; set; }

        public double? DEFAULTEFFECT { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MARKER_ID { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_MARKER IGEN_MARKER { get; set; }

        public virtual IGEN_RESULTEFFECT IGEN_RESULTEFFECT { get; set; }
    }
}
