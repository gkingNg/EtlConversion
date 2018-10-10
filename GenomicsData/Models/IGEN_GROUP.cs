using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_GROUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_GROUP()
        {
            IGEN_GROUPMEMBER = new HashSet<IGEN_GROUPMEMBER>();
        }

        [Key]
        public int GROUP_ID { get; set; }

        [Required]
        [StringLength(80)]
        public string NAME { get; set; }

        public int OWNER_CUST_ID { get; set; }

        public bool ACTIVE { get; set; }

        [StringLength(4000)]
        public string COMMENTS { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_GROUPMEMBER> IGEN_GROUPMEMBER { get; set; }
    }
}
