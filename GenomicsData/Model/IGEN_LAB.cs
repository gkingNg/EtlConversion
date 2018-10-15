using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Model
{
    public partial class IGEN_LAB : BaseIgenEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_LAB()
        {
 
            IGEN_IGENITYORDER = new HashSet<IGEN_IGENITYORDER>();

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



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_IGENITYORDER> IGEN_IGENITYORDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_USER> IGEN_USER { get; set; }
    }
}
