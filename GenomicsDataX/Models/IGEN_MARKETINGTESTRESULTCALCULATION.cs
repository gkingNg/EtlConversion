using System;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_MARKETINGTESTRESULTCALCULATION
    {
        [Key]
        public int CALCULATION_ID { get; set; }

        public int MARKETINGTEST_ID { get; set; }

        public int SCIENTIFICTEST_ID { get; set; }

        public int? CALCULATIONMARKETINGTEST_ID { get; set; }

        [StringLength(10)]
        public string BREED { get; set; }

        [StringLength(10)]
        public string SEX { get; set; }

        public double? WEIGHT { get; set; }

        public double? DEVIATION { get; set; }

        public double? CORRECTION { get; set; }

        public double? MULTIPLIER { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_MARKETINGTEST IGEN_MARKETINGTEST { get; set; }

        public virtual IGEN_SCIENTIFICTEST IGEN_SCIENTIFICTEST { get; set; }
    }
}
