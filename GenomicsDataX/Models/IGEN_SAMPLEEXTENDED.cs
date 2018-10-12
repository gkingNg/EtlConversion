using System;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_SAMPLEEXTENDED
    {
        public long ID { get; set; }

        public int SAMPLE_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string KEY { get; set; }

        [StringLength(255)]
        public string VALUE { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_SAMPLE IGEN_SAMPLE { get; set; }
    }
}
