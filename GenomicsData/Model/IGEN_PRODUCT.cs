using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Model
{
    public partial class IGEN_PRODUCT : BaseIgenEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_PRODUCT()
        {
            IGEN_ERPPRODUCT = new HashSet<IGEN_ERPPRODUCT>();

            IGEN_SAMPLEPRODUCTMAP = new HashSet<IGEN_SAMPLEPRODUCTMAP>();
        }

        [Key]
        public int PRODUCT_ID { get; set; }

        public bool ACTIVE { get; set; }

        public int? DISPLAYPRIORITY { get; set; }

        [StringLength(4000)]
        public string COMMENTS { get; set; }

        public int? SCIENTIFICTEST_ID { get; set; }


        public int? LIMS_iProductID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_ERPPRODUCT> IGEN_ERPPRODUCT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        public virtual IGEN_SCIENTIFICTEST IGEN_SCIENTIFICTEST { get; set; }

        public virtual ICollection<IGEN_SAMPLEPRODUCTMAP> IGEN_SAMPLEPRODUCTMAP { get; set; }

    }
}
