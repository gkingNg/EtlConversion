using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_RESULTDIRECTEFFECT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_RESULTDIRECTEFFECT()
        {
            IGEN_RESULTDIRECTEFFECTSCORE = new HashSet<IGEN_RESULTDIRECTEFFECTSCORE>();
        }

        [Key]
        public int RESULTDIRECTEFFECT_ID { get; set; }

        public double SCOREHIGH { get; set; }

        public double SCORELOW { get; set; }

        public int? RESULTMAP_ID { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_RESULTDIRECTEFFECTSCORE> IGEN_RESULTDIRECTEFFECTSCORE { get; set; }

        public virtual IGEN_RESULTMAP IGEN_RESULTMAP { get; set; }
    }
}
