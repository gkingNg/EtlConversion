using System;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class TraitMarketingTest
    {
        public int TraitMarketingTestId { get; set; }

        [Required]
        [StringLength(50)]
        public string TraitName { get; set; }

        public int MarketingTestId { get; set; }

        public int Priority { get; set; }

        public DateTime dLastDWUpdate { get; set; }
    }
}
