using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_SAMPLESCIENTIFICTESTMAP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SCIENTIFICTEST_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SAMPLE_ID { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_SAMPLE IGEN_SAMPLE { get; set; }

        public virtual IGEN_SCIENTIFICTEST IGEN_SCIENTIFICTEST { get; set; }
    }
}
