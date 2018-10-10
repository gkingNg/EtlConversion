using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_CUSTOMERPROGRAMPERIOD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_CUSTOMERPROGRAMPERIOD()
        {
            IGEN_CUSTOMERPROGRAM = new HashSet<IGEN_CUSTOMERPROGRAM>();
        }

        [Key]
        public int PROGRAMPERIOD_ID { get; set; }

        public int CUSTOMER_ID { get; set; }

        public int SEASON_ID { get; set; }

        [StringLength(250)]
        public string COMMENTS { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_CUSTOMER IGEN_CUSTOMER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_CUSTOMERPROGRAM> IGEN_CUSTOMERPROGRAM { get; set; }

        public virtual IGEN_SEASON IGEN_SEASON { get; set; }
    }
}
