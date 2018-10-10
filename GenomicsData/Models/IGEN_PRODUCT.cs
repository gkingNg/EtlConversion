using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_PRODUCT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_PRODUCT()
        {
            IGEN_ERPPRODUCT = new HashSet<IGEN_ERPPRODUCT>();
            IGEN_MarketingTestResultfieldMap = new HashSet<IGEN_MarketingTestResultfieldMap>();
            Igen_TransferProduct = new HashSet<Igen_TransferProduct>();
            IGEN_PRODUCTLOCALE = new HashSet<IGEN_PRODUCTLOCALE>();
            IGEN_PRODUCTMARKETINGTESTMAP = new HashSet<IGEN_PRODUCTMARKETINGTESTMAP>();
            IGEN_PRODUCTTESTOVERRIDE = new HashSet<IGEN_PRODUCTTESTOVERRIDE>();
            IGEN_SAMPLEPRODUCTMAP = new HashSet<IGEN_SAMPLEPRODUCTMAP>();
            IGEN_SAMPLEPRODUCTREPORTSTATUS = new HashSet<IGEN_SAMPLEPRODUCTREPORTSTATUS>();
        }

        [Key]
        public int PRODUCT_ID { get; set; }

        public bool ACTIVE { get; set; }

        public int? DISPLAYPRIORITY { get; set; }

        [StringLength(4000)]
        public string COMMENTS { get; set; }

        public int? SCIENTIFICTEST_ID { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public int? LIMS_iProductID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_ERPPRODUCT> IGEN_ERPPRODUCT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MarketingTestResultfieldMap> IGEN_MarketingTestResultfieldMap { get; set; }

        public virtual IGEN_SCIENTIFICTEST IGEN_SCIENTIFICTEST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Igen_TransferProduct> Igen_TransferProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_PRODUCTLOCALE> IGEN_PRODUCTLOCALE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_PRODUCTMARKETINGTESTMAP> IGEN_PRODUCTMARKETINGTESTMAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_PRODUCTTESTOVERRIDE> IGEN_PRODUCTTESTOVERRIDE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_SAMPLEPRODUCTMAP> IGEN_SAMPLEPRODUCTMAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_SAMPLEPRODUCTREPORTSTATUS> IGEN_SAMPLEPRODUCTREPORTSTATUS { get; set; }
    }
}
