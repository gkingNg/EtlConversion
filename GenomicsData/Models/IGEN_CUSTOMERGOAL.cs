using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_CUSTOMERGOAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_CUSTOMERGOAL()
        {
            IGEN_CUSTOMERGOALWEIGHT = new HashSet<IGEN_CUSTOMERGOALWEIGHT>();
        }

        [Key]
        public int GOAL_ID { get; set; }

        public int CUSTOMER_ID { get; set; }

        public int SEASON_ID { get; set; }

        public bool ISACTIVE { get; set; }

        [StringLength(250)]
        public string COMMENTS { get; set; }

        public int? MARKETINGINDEXPERIOD_ID { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_CUSTOMER IGEN_CUSTOMER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_CUSTOMERGOALWEIGHT> IGEN_CUSTOMERGOALWEIGHT { get; set; }

        public virtual IGEN_MARKETINGINDEXPERIOD IGEN_MARKETINGINDEXPERIOD { get; set; }

        public virtual IGEN_SEASON IGEN_SEASON { get; set; }
    }
}
