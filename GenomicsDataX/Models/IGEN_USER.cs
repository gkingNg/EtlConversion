using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_USER()
        {
            IGEN_IGENITYORDER = new HashSet<IGEN_IGENITYORDER>();
            IGEN_PENDINGANIMAL = new HashSet<IGEN_PENDINGANIMAL>();
            IGEN_SCIENTIFICRESULT = new HashSet<IGEN_SCIENTIFICRESULT>();
            IGEN_PAYMENTTRANSACTION = new HashSet<IGEN_PAYMENTTRANSACTION>();
            IGEN_SAMPLEPRODUCTREPORTSTATUS = new HashSet<IGEN_SAMPLEPRODUCTREPORTSTATUS>();
        }

        [Key]
        public int USER_ID { get; set; }

        [Required]
        [StringLength(40)]
        public string USERNAME { get; set; }

        [Required]
        [StringLength(255)]
        public string PASSWORD { get; set; }

        public bool ACTIVE { get; set; }

        [StringLength(40)]
        public string LASTNAME { get; set; }

        [StringLength(40)]
        public string FIRSTNAME { get; set; }

        [Required]
        [StringLength(40)]
        public string EMAIL { get; set; }

        [Required]
        [StringLength(80)]
        public string ROLES { get; set; }

        public int? ERP_ID { get; set; }

        public int? LAB_ID { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_ERP IGEN_ERP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_IGENITYORDER> IGEN_IGENITYORDER { get; set; }

        public virtual IGEN_LAB IGEN_LAB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_PENDINGANIMAL> IGEN_PENDINGANIMAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_SCIENTIFICRESULT> IGEN_SCIENTIFICRESULT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_PAYMENTTRANSACTION> IGEN_PAYMENTTRANSACTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_SAMPLEPRODUCTREPORTSTATUS> IGEN_SAMPLEPRODUCTREPORTSTATUS { get; set; }
    }
}
