using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_RESULTMAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_RESULTMAP()
        {
            IGEN_MARKETINGTESTRESULT = new HashSet<IGEN_MARKETINGTESTRESULT>();
            IGEN_RESULTDIRECTEFFECT = new HashSet<IGEN_RESULTDIRECTEFFECT>();
            IGEN_RESULTEFFECT = new HashSet<IGEN_RESULTEFFECT>();
            IGEN_MARKETINGTESTRESULT_HIST = new HashSet<IGEN_MARKETINGTESTRESULT_HIST>();
            IGEN_RESULTMAPRESULT = new HashSet<IGEN_RESULTMAPRESULT>();
        }

        [Key]
        public int RESULTMAP_ID { get; set; }

        [StringLength(80)]
        public string DESCRIPTION { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime EFFECTIVESTARTDATE { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EFFECTIVEENDDATE { get; set; }

        public bool MARKERCHANGEVERSION { get; set; }

        public int MARKETINGMARKERPERIOD_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string RESULTMAPTYPE { get; set; }

        [Required]
        [StringLength(20)]
        public string SORTTYPE { get; set; }

        [StringLength(20)]
        public string RESULTLOOKUPTYPE { get; set; }

        [StringLength(4000)]
        public string COMMENTS { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_MARKETINGMARKERSPERIOD IGEN_MARKETINGMARKERSPERIOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MARKETINGTESTRESULT> IGEN_MARKETINGTESTRESULT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_RESULTDIRECTEFFECT> IGEN_RESULTDIRECTEFFECT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_RESULTEFFECT> IGEN_RESULTEFFECT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MARKETINGTESTRESULT_HIST> IGEN_MARKETINGTESTRESULT_HIST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_RESULTMAPRESULT> IGEN_RESULTMAPRESULT { get; set; }
    }
}
