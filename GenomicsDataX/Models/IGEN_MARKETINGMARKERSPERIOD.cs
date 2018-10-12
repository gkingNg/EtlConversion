using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_MARKETINGMARKERSPERIOD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_MARKETINGMARKERSPERIOD()
        {
            IGEN_MARKERPERIODMARKERMAP = new HashSet<IGEN_MARKERPERIODMARKERMAP>();
            IGEN_RESULTMAP = new HashSet<IGEN_RESULTMAP>();
        }

        [Key]
        public int MARKETINGMARKERPERIOD_ID { get; set; }

        public int MARKETINGTEST_ID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime EFFECTIVESTARTDATE { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EFFECTIVEENDDATE { get; set; }

        [StringLength(4000)]
        public string COMMENTS { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MARKERPERIODMARKERMAP> IGEN_MARKERPERIODMARKERMAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_RESULTMAP> IGEN_RESULTMAP { get; set; }

        public virtual IGEN_MARKETINGTEST IGEN_MARKETINGTEST { get; set; }
    }
}
