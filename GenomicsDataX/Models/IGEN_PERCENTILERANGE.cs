using System;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_PERCENTILERANGE
    {
        [Key]
        public int PERCENTILERANGE_ID { get; set; }

        public int BREED_ID { get; set; }

        public int DECILE { get; set; }

        public int PERCENTILE { get; set; }

        public double? RANGEVALUE { get; set; }

        public DateTime RANGEDATE { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_breed_old IGEN_breed_old { get; set; }
    }
}
