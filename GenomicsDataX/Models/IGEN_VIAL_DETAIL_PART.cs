using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_VIAL_DETAIL_PART
    {
        public int? FORMID { get; set; }

        [StringLength(30)]
        public string SAMPLEID { get; set; }

        [StringLength(15)]
        public string CUSTNMBR { get; set; }

        public int? SOPMSTRNUMB { get; set; }

        [StringLength(30)]
        public string ANIMALID { get; set; }

        [Key]
        [Column(Order = 0)]
        public long SSIS_uniqueID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime dLastDWUpdate { get; set; }
    }
}
