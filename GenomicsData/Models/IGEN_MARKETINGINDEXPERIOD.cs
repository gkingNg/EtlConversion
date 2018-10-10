using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_MARKETINGINDEXPERIOD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_MARKETINGINDEXPERIOD()
        {
            IGEN_CUSTOMERGOAL = new HashSet<IGEN_CUSTOMERGOAL>();
            IGEN_MARKETINGINDEXTESTMAP = new HashSet<IGEN_MARKETINGINDEXTESTMAP>();
        }

        [Key]
        public int MARKETINGINDEXPERIOD_ID { get; set; }

        public int MARKETINGTEST_ID { get; set; }

        public int SEASON_ID { get; set; }

        [StringLength(250)]
        public string COMMENTS { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_CUSTOMERGOAL> IGEN_CUSTOMERGOAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MARKETINGINDEXTESTMAP> IGEN_MARKETINGINDEXTESTMAP { get; set; }

        public virtual IGEN_MARKETINGTEST IGEN_MARKETINGTEST { get; set; }

        public virtual IGEN_SEASON IGEN_SEASON { get; set; }
    }
}
