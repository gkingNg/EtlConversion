using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_POTENTIALSIRE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_POTENTIALSIRE()
        {
            IGEN_SIREEXCLUDEDMARKER = new HashSet<IGEN_SIREEXCLUDEDMARKER>();
        }

        [Key]
        public int POTENTIALSIRE_ID { get; set; }

        public int CALFSAMPLE_ID { get; set; }

        public int? SIRESAMPLE_ID { get; set; }

        [StringLength(40)]
        public string BREEDASSOCIATIONID { get; set; }

        public bool? LIKELY { get; set; }

        public bool? QUALIFIES { get; set; }

        public int? EXCLUSIONS { get; set; }

        public int? PROBABILITY { get; set; }

        [StringLength(10)]
        public string BREED1 { get; set; }

        [StringLength(10)]
        public string BREED2 { get; set; }

        public int? NUMLOCICOMPARED { get; set; }

        public int? EXCLUSIONSSINGLE { get; set; }

        public int? EXCLUSIONSBOTH { get; set; }

        [StringLength(20)]
        public string CASENUM { get; set; }

        [StringLength(40)]
        public string BARCODEID { get; set; }

        [StringLength(40)]
        public string ANIMALID { get; set; }

        [StringLength(40)]
        public string ANIMALID2 { get; set; }

        [StringLength(25)]
        public string PARENTAGEOPTION { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_SAMPLE IGEN_SAMPLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_SIREEXCLUDEDMARKER> IGEN_SIREEXCLUDEDMARKER { get; set; }

        public virtual IGEN_SAMPLE IGEN_SAMPLE1 { get; set; }
    }
}
