using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_COMPSALESREP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_COMPSALESREP()
        {
            IGEN_CUSTOMER = new HashSet<IGEN_CUSTOMER>();
            IGEN_IGENITYORDER = new HashSet<IGEN_IGENITYORDER>();
        }

        [Key]
        public int COMPSALESREP_ID { get; set; }

        public int COMPPROVIDER_ID { get; set; }

        [Required]
        [StringLength(40)]
        public string NAME { get; set; }

        [Required]
        [StringLength(40)]
        public string EXTERNALID { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_COMPPROVIDER IGEN_COMPPROVIDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_CUSTOMER> IGEN_CUSTOMER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_IGENITYORDER> IGEN_IGENITYORDER { get; set; }
    }
}
