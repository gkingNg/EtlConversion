using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_PARENTMATCHORDER
    {
        [Key]
        public int PARENTMATCHORDER_ID { get; set; }

        public int PARENTMATCHORDERGROUP_ID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime PARENTMATCHORDER_DATE { get; set; }

        [Required]
        [StringLength(2)]
        public string PARENTMATCH_TYPE { get; set; }

        public int CALF_SAMPLEID { get; set; }

        [StringLength(40)]
        public string SIRE_BREEDASSOCIATIONID { get; set; }

        [StringLength(40)]
        public string DAM_BREEDASSOCIATIONID { get; set; }

        public int? SIRE_SAMPLEID { get; set; }

        public int? DAM_SAMPLEID { get; set; }

        public bool? SIRE_LIKELY { get; set; }

        public int? SIRE_QUALIFIES { get; set; }

        public int? SIRE_EXCLUSIONS { get; set; }

        public int? SIRE_PROBABILITY { get; set; }

        public int? SIRE_NUMCOMPAREDLOCI { get; set; }

        public int? SIRE_EXCLUSIONSSINGLE { get; set; }

        public int? SIRE_EXCLUSIONSBOTH { get; set; }

        public bool? DAM_LIKELY { get; set; }

        public int? DAM_QUALIFIES { get; set; }

        public int? DAM_EXCLUSIONS { get; set; }

        public int? DAM_PROBABILITY { get; set; }

        public int? DAM_NUMCOMPAREDLOCI { get; set; }

        public int? DAM_EXCLUSIONSSINGLE { get; set; }

        public int? DAM_EXCLUSIONSBOTH { get; set; }

        public int? BOTH_QUALIFY { get; set; }

        [StringLength(250)]
        public string COMMENTS { get; set; }

        public int? SIRE_SMRANK { get; set; }

        public int? SIRE_SMPROB { get; set; }

        public int? DAM_SMRANK { get; set; }

        public int? DAM_SMPROB { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_PARENTMATCHORDERGROUP IGEN_PARENTMATCHORDERGROUP { get; set; }
    }
}
