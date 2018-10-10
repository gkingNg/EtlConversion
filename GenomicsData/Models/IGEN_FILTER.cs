using System;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_FILTER
    {
        [Key]
        public int FILTER_ID { get; set; }

        public int SORTFILTER_ID { get; set; }

        public int MARKETINGTEST_ID { get; set; }

        [StringLength(10)]
        public string EXPRESSION { get; set; }

        [StringLength(10)]
        public string VALUE1 { get; set; }

        [StringLength(10)]
        public string VALUE2 { get; set; }

        public int? WEIGHT { get; set; }

        [StringLength(10)]
        public string SORTORDER { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_MARKETINGTEST IGEN_MARKETINGTEST { get; set; }

        public virtual IGEN_SORTFILTER IGEN_SORTFILTER { get; set; }
    }
}
