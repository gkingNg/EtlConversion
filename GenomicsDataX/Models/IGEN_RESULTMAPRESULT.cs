using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_RESULTMAPRESULT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_RESULTMAPRESULT()
        {
            IGEN_RESULTMAPRESULTTEXT = new HashSet<IGEN_RESULTMAPRESULTTEXT>();
            IGEN_RESULTMAPRESULTMARKER = new HashSet<IGEN_RESULTMAPRESULTMARKER>();
        }

        [Key]
        public int RESULTMAPRESULT_ID { get; set; }

        public int RESULTMAP_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string MARKETINGRESULT { get; set; }

        public int CONFIDENCE { get; set; }

        [StringLength(40)]
        public string GENOTYPE { get; set; }

        public double? SORTVALUE { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_RESULTMAP IGEN_RESULTMAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_RESULTMAPRESULTTEXT> IGEN_RESULTMAPRESULTTEXT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_RESULTMAPRESULTMARKER> IGEN_RESULTMAPRESULTMARKER { get; set; }
    }
}
