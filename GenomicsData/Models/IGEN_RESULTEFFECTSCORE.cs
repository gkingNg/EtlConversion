using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_RESULTEFFECTSCORE
    {
        [Key]
        [Column(Order = 0)]
        public double SCORE { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RESULTEFFECT_ID { get; set; }

        public double MINIMUMVALUE { get; set; }

        public double? SORTVALUE { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_RESULTEFFECT IGEN_RESULTEFFECT { get; set; }
    }
}
