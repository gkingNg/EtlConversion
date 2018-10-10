using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_MARKETINGTEST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_MARKETINGTEST()
        {
            IGEN_FILTER = new HashSet<IGEN_FILTER>();
            IGEN_MARKETINGINDEXPERIOD = new HashSet<IGEN_MARKETINGINDEXPERIOD>();
            IGEN_MARKETINGMARKERSPERIOD = new HashSet<IGEN_MARKETINGMARKERSPERIOD>();
            IGEN_MarketingTestResultfieldMap = new HashSet<IGEN_MarketingTestResultfieldMap>();
            Igen_TransferProduct = new HashSet<Igen_TransferProduct>();
            IGEN_MARKETINGTESTRESULTCALCULATION = new HashSet<IGEN_MARKETINGTESTRESULTCALCULATION>();
            IGEN_CUSTOMERGOALWEIGHT = new HashSet<IGEN_CUSTOMERGOALWEIGHT>();
            IGEN_MARKETINGINDEXTESTMAP = new HashSet<IGEN_MARKETINGINDEXTESTMAP>();
            IGEN_MARKETINGTESTGROUPTESTMAP = new HashSet<IGEN_MARKETINGTESTGROUPTESTMAP>();
            IGEN_MARKETINGTESTLOCALE = new HashSet<IGEN_MARKETINGTESTLOCALE>();
            IGEN_MARKETINGTESTRESULT = new HashSet<IGEN_MARKETINGTESTRESULT>();
            IGEN_MARKETINGTESTRESULT_HIST = new HashSet<IGEN_MARKETINGTESTRESULT_HIST>();
            IGEN_PRODUCTMARKETINGTESTMAP = new HashSet<IGEN_PRODUCTMARKETINGTESTMAP>();
            IGEN_SCIENTIFICMARKETINGMAP = new HashSet<IGEN_SCIENTIFICMARKETINGMAP>();
        }

        [Key]
        public int MARKETINGTEST_ID { get; set; }

        public bool ISPARENTMATCH { get; set; }

        public bool ACTIVE { get; set; }

        public int CONFIDENCEREQUIRED { get; set; }

        public int? DISPLAYPRIORITY { get; set; }

        [StringLength(40)]
        public string EFFECTUOM { get; set; }

        [StringLength(4000)]
        public string COMMENTS { get; set; }

        [StringLength(5)]
        public string ABBREVIATION { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_FILTER> IGEN_FILTER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MARKETINGINDEXPERIOD> IGEN_MARKETINGINDEXPERIOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MARKETINGMARKERSPERIOD> IGEN_MARKETINGMARKERSPERIOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MarketingTestResultfieldMap> IGEN_MarketingTestResultfieldMap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Igen_TransferProduct> Igen_TransferProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MARKETINGTESTRESULTCALCULATION> IGEN_MARKETINGTESTRESULTCALCULATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_CUSTOMERGOALWEIGHT> IGEN_CUSTOMERGOALWEIGHT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MARKETINGINDEXTESTMAP> IGEN_MARKETINGINDEXTESTMAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MARKETINGTESTGROUPTESTMAP> IGEN_MARKETINGTESTGROUPTESTMAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MARKETINGTESTLOCALE> IGEN_MARKETINGTESTLOCALE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MARKETINGTESTRESULT> IGEN_MARKETINGTESTRESULT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MARKETINGTESTRESULT_HIST> IGEN_MARKETINGTESTRESULT_HIST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_PRODUCTMARKETINGTESTMAP> IGEN_PRODUCTMARKETINGTESTMAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_SCIENTIFICMARKETINGMAP> IGEN_SCIENTIFICMARKETINGMAP { get; set; }
    }
}
