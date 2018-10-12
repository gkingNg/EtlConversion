using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_COMPPROVIDER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_COMPPROVIDER()
        {
            IGEN_COMPPROVIDERSCHEDULE = new HashSet<IGEN_COMPPROVIDERSCHEDULE>();
            IGEN_COMPSALESREP = new HashSet<IGEN_COMPSALESREP>();
        }

        [Key]
        public int COMPPROVIDER_ID { get; set; }

        [Required]
        [StringLength(40)]
        public string NAME { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_COMPPROVIDERSCHEDULE> IGEN_COMPPROVIDERSCHEDULE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_COMPSALESREP> IGEN_COMPSALESREP { get; set; }
    }
}
