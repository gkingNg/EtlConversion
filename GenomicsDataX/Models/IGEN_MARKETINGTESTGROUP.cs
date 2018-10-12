using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_MARKETINGTESTGROUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_MARKETINGTESTGROUP()
        {
            IGEN_MARKETINGTESTGROUPLOCALE = new HashSet<IGEN_MARKETINGTESTGROUPLOCALE>();
            IGEN_MARKETINGTESTGROUPTESTMAP = new HashSet<IGEN_MARKETINGTESTGROUPTESTMAP>();
        }

        [Key]
        public int MARKETINGTESTGROUP_ID { get; set; }

        [StringLength(10)]
        public string ABBREVIATION { get; set; }

        [StringLength(250)]
        public string COMMENTS { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MARKETINGTESTGROUPLOCALE> IGEN_MARKETINGTESTGROUPLOCALE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MARKETINGTESTGROUPTESTMAP> IGEN_MARKETINGTESTGROUPTESTMAP { get; set; }
    }
}
