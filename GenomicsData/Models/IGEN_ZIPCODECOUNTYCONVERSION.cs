using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_ZIPCODECOUNTYCONVERSION
    {
        [StringLength(50)]
        public string ZIPCODE { get; set; }

        [StringLength(50)]
        public string CITY { get; set; }

        [StringLength(50)]
        public string STATE { get; set; }

        [StringLength(50)]
        public string COUNTY { get; set; }

        [StringLength(50)]
        public string AREACODE { get; set; }

        [StringLength(50)]
        public string CITYTYPE { get; set; }

        [StringLength(50)]
        public string CITYALIASABBREV { get; set; }

        [StringLength(50)]
        public string CITYALIASNAME { get; set; }

        public double? LATITUDE { get; set; }

        public double? LONGITUDE { get; set; }

        [StringLength(50)]
        public string TIMEZONE { get; set; }

        public double? ELEVATION { get; set; }

        [StringLength(50)]
        public string COUNTYFIPS { get; set; }

        [StringLength(50)]
        public string DAYLIGHTSAVINGS { get; set; }

        [Key]
        [Column(Order = 0)]
        public long SSIS_uniqueID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime dLastDWUpdate { get; set; }
    }
}
