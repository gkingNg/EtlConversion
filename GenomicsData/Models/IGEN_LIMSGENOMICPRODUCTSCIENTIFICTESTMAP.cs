using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_LIMSGENOMICPRODUCTSCIENTIFICTESTMAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_LIMSGENOMICPRODUCTSCIENTIFICTESTMAP()
        {
            IGEN_PRODUCTSUSEDBY = new HashSet<IGEN_PRODUCTSUSEDBY>();
        }

        [Key]
        public long uniqueID { get; set; }

        public long iProductID { get; set; }

        public int PRODUCT_ID { get; set; }

        public int SCIENTIFICTEST_ID { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_PRODUCTSUSEDBY> IGEN_PRODUCTSUSEDBY { get; set; }
    }
}
