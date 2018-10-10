using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_breed_old
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_breed_old()
        {
            IGEN_PERCENTILERANGE = new HashSet<IGEN_PERCENTILERANGE>();
        }

        [StringLength(10)]
        public string BREED { get; set; }

        [StringLength(20)]
        public string BREEDASSOCIATIONCODE { get; set; }

        [StringLength(100)]
        public string BREED_NAME { get; set; }

        [StringLength(100)]
        public string BREEDASSOC_NAME { get; set; }

        public int? PRIORITY { get; set; }

        [StringLength(40)]
        public string GACONTACTFIRSTNAME { get; set; }

        [StringLength(40)]
        public string GACONTACTLASTNAME { get; set; }

        [StringLength(80)]
        public string GACONTACTEMAIL { get; set; }

        [Key]
        public int BREED_ID { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_PERCENTILERANGE> IGEN_PERCENTILERANGE { get; set; }
    }
}
