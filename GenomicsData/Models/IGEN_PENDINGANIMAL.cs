using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_PENDINGANIMAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_PENDINGANIMAL()
        {
            IGEN_PENDINGANIMALNOTIFY = new HashSet<IGEN_PENDINGANIMALNOTIFY>();
            IGEN_PENDINGANIMALSTATUS = new HashSet<IGEN_PENDINGANIMALSTATUS>();
        }

        [Key]
        public int PENDINGANIMAL_ID { get; set; }

        public int CUSTOMER_ID { get; set; }

        public int USER_ID { get; set; }

        public int? SAMPLE_ID { get; set; }

        [StringLength(40)]
        public string ANIMALID { get; set; }

        [StringLength(40)]
        public string ANIMALID2 { get; set; }

        [StringLength(10)]
        public string SEX { get; set; }

        [StringLength(10)]
        public string BREED1 { get; set; }

        [StringLength(10)]
        public string BREED2 { get; set; }

        [StringLength(20)]
        public string BREEDASSOCIATIONCODE1 { get; set; }

        [StringLength(40)]
        public string REGISTRATIONNUMBER1 { get; set; }

        [StringLength(20)]
        public string BREEDASSOCIATIONCODE2 { get; set; }

        [StringLength(40)]
        public string REGISTRATIONNUMBER2 { get; set; }

        public bool POSSIBLEMATCH_FOUND { get; set; }

        [StringLength(4000)]
        public string COMMENTS { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_CUSTOMER IGEN_CUSTOMER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_PENDINGANIMALNOTIFY> IGEN_PENDINGANIMALNOTIFY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_PENDINGANIMALSTATUS> IGEN_PENDINGANIMALSTATUS { get; set; }

        public virtual IGEN_SAMPLE IGEN_SAMPLE { get; set; }

        public virtual IGEN_USER IGEN_USER { get; set; }
    }
}
