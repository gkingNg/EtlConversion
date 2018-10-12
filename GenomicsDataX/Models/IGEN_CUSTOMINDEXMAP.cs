using System;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_CUSTOMINDEXMAP
    {
        [Key]
        public int CUSTOMINDEXMAP_ID { get; set; }

        public int SEASON_ID { get; set; }

        [StringLength(250)]
        public string COMMENTS { get; set; }

        public DateTime dLastDWUpdate { get; set; }
    }
}
