using System;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_MARKERALIAS
    {
        [Key]
        [StringLength(40)]
        public string NAME { get; set; }

        public int MARKER_ID { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_MARKER IGEN_MARKER { get; set; }
    }
}
