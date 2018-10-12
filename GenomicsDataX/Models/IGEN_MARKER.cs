using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_MARKER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_MARKER()
        {
            IGEN_ABMAPPING = new HashSet<IGEN_ABMAPPING>();
            IGEN_DAMEXCLUDEDMARKER = new HashSet<IGEN_DAMEXCLUDEDMARKER>();
            IGEN_MARKERMICROSAT = new HashSet<IGEN_MARKERMICROSAT>();
            IGEN_MARKERALIAS = new HashSet<IGEN_MARKERALIAS>();
            IGEN_MARKERPERIODMARKERMAP = new HashSet<IGEN_MARKERPERIODMARKERMAP>();
            IGEN_RESULTEFFECTMARKER = new HashSet<IGEN_RESULTEFFECTMARKER>();
            IGEN_RESULTMAPRESULTMARKER = new HashSet<IGEN_RESULTMAPRESULTMARKER>();
            IGEN_SIREEXCLUDEDMARKER = new HashSet<IGEN_SIREEXCLUDEDMARKER>();
            IGEN_SCIENTIFICRESULTMARKER = new HashSet<IGEN_SCIENTIFICRESULTMARKER>();
            IGEN_SCIENTIFICTESTMARKERMAP = new HashSet<IGEN_SCIENTIFICTESTMARKERMAP>();
        }

        [Key]
        public int MARKER_ID { get; set; }

        [Required]
        [StringLength(40)]
        public string NAME { get; set; }

        [StringLength(80)]
        public string DESCRIPTION { get; set; }

        [StringLength(10)]
        public string RESULT1 { get; set; }

        [StringLength(10)]
        public string RESULT2 { get; set; }

        public bool ROYALTYMARKER { get; set; }

        public bool ISMICROSAT { get; set; }

        public bool ISPARENTMATCH { get; set; }

        public bool ISBREEDASSOCIATION { get; set; }

        public bool ISDIRECTRESULT { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_ABMAPPING> IGEN_ABMAPPING { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_DAMEXCLUDEDMARKER> IGEN_DAMEXCLUDEDMARKER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MARKERMICROSAT> IGEN_MARKERMICROSAT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MARKERALIAS> IGEN_MARKERALIAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MARKERPERIODMARKERMAP> IGEN_MARKERPERIODMARKERMAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_RESULTEFFECTMARKER> IGEN_RESULTEFFECTMARKER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_RESULTMAPRESULTMARKER> IGEN_RESULTMAPRESULTMARKER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_SIREEXCLUDEDMARKER> IGEN_SIREEXCLUDEDMARKER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_SCIENTIFICRESULTMARKER> IGEN_SCIENTIFICRESULTMARKER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_SCIENTIFICTESTMARKERMAP> IGEN_SCIENTIFICTESTMARKERMAP { get; set; }
    }
}
