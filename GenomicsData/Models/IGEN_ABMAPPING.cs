using System;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_ABMAPPING
    {
        [Key]
        public int ABMAPPING_ID { get; set; }

        public int MARKER_ID { get; set; }

        public bool FLIP_LOOKUP { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_MARKER IGEN_MARKER { get; set; }
    }
}
