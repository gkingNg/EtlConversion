using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_LAB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_LAB()
        {
            IGEN_CONFLICT = new HashSet<IGEN_CONFLICT>();
            IGEN_IGENITYORDER = new HashSet<IGEN_IGENITYORDER>();
            IGEN_LABSCIENTIFICTESTMAP = new HashSet<IGEN_LABSCIENTIFICTESTMAP>();
            IGEN_SAMPLELABETA = new HashSet<IGEN_SAMPLELABETA>();
            IGEN_USER = new HashSet<IGEN_USER>();
        }

        [Key]
        public int LAB_ID { get; set; }

        public bool ACTIVE { get; set; }

        [Required]
        [StringLength(40)]
        public string NAME { get; set; }

        [StringLength(4000)]
        public string COMMENTS { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_CONFLICT> IGEN_CONFLICT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_IGENITYORDER> IGEN_IGENITYORDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_LABSCIENTIFICTESTMAP> IGEN_LABSCIENTIFICTESTMAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_SAMPLELABETA> IGEN_SAMPLELABETA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_USER> IGEN_USER { get; set; }
    }
}
