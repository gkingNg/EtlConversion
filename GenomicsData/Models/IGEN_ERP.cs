using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_ERP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_ERP()
        {
            IGEN_CUSTOMER = new HashSet<IGEN_CUSTOMER>();
            IGEN_ERPPRODUCT = new HashSet<IGEN_ERPPRODUCT>();
            IGEN_PRODUCTTESTOVERRIDE = new HashSet<IGEN_PRODUCTTESTOVERRIDE>();
            IGEN_USER = new HashSet<IGEN_USER>();
        }

        [Key]
        public int ERP_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string NAME { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_CUSTOMER> IGEN_CUSTOMER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_ERPPRODUCT> IGEN_ERPPRODUCT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_PRODUCTTESTOVERRIDE> IGEN_PRODUCTTESTOVERRIDE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_USER> IGEN_USER { get; set; }
    }
}
