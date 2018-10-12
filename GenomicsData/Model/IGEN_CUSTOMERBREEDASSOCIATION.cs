using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Model
{
    public partial class IGEN_CUSTOMERBREEDASSOCIATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_CUSTOMERBREEDASSOCIATION()
        {
            IGEN_ANIMALBREEDASSOCIATION = new HashSet<IGEN_ANIMALBREEDASSOCIATION>();
        }

        [Key]
        public int CUSTOMERBREEDASSOC_ID { get; set; }

        public int CUSTOMER_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string BREEDASSOCIATIONCODE { get; set; }

        [StringLength(40)]
        public string MEMBERNUMBER { get; set; }

        public DateTime dLastDWUpdate { get; set; } = DateTime.Now;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_ANIMALBREEDASSOCIATION> IGEN_ANIMALBREEDASSOCIATION { get; set; }

        public virtual IGEN_CUSTOMER IGEN_CUSTOMER { get; set; }
    }
}
