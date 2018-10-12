using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_LOCALE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_LOCALE()
        {
            IGEN_MARKETINGTESTGROUPLOCALE = new HashSet<IGEN_MARKETINGTESTGROUPLOCALE>();
            IGEN_MARKETINGTESTLOCALE = new HashSet<IGEN_MARKETINGTESTLOCALE>();
            IGEN_PRODUCTLOCALE = new HashSet<IGEN_PRODUCTLOCALE>();
        }

        [Key]
        public int LOCALE_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string LANGUAGE { get; set; }

        [Required]
        [StringLength(40)]
        public string LOCALE { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MARKETINGTESTGROUPLOCALE> IGEN_MARKETINGTESTGROUPLOCALE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MARKETINGTESTLOCALE> IGEN_MARKETINGTESTLOCALE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_PRODUCTLOCALE> IGEN_PRODUCTLOCALE { get; set; }
    }
}
