using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_SORTFILTER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_SORTFILTER()
        {
            IGEN_FILTER = new HashSet<IGEN_FILTER>();
        }

        [Key]
        public int SORTFILTER_ID { get; set; }

        [Required]
        [StringLength(40)]
        public string NAME { get; set; }

        public int LOGIN_ID { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_FILTER> IGEN_FILTER { get; set; }

        public virtual IGEN_LOGIN IGEN_LOGIN { get; set; }
    }
}
