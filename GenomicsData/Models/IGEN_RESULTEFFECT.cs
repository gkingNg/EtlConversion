using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_RESULTEFFECT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_RESULTEFFECT()
        {
            IGEN_RESULTEFFECTMARKER = new HashSet<IGEN_RESULTEFFECTMARKER>();
            IGEN_RESULTEFFECTSCORE = new HashSet<IGEN_RESULTEFFECTSCORE>();
        }

        [Key]
        public int RESULTEFFECT_ID { get; set; }

        public double SCOREHIGH { get; set; }

        public double SCORELOW { get; set; }

        public double MINMARKERS { get; set; }

        public double THRESHOLD { get; set; }

        public int MISSINGMARKERBEHAVIOR { get; set; }

        public double? MINOBSERVEDEFFECT { get; set; }

        public double? MAXOBSERVEDEFFECT { get; set; }

        public double? MEANADJUSTMENT { get; set; }

        public bool? ADJUSTTOZERO { get; set; }

        public int? RESULTMAP_ID { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_RESULTEFFECTMARKER> IGEN_RESULTEFFECTMARKER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_RESULTEFFECTSCORE> IGEN_RESULTEFFECTSCORE { get; set; }

        public virtual IGEN_RESULTMAP IGEN_RESULTMAP { get; set; }
    }
}
