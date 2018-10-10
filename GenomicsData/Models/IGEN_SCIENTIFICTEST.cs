using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_SCIENTIFICTEST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_SCIENTIFICTEST()
        {
            IGEN_LABSCIENTIFICTESTMAP = new HashSet<IGEN_LABSCIENTIFICTESTMAP>();
            IGEN_MARKETINGTESTRESULTCALCULATION = new HashSet<IGEN_MARKETINGTESTRESULTCALCULATION>();
            IGEN_PRODUCT = new HashSet<IGEN_PRODUCT>();
            IGEN_SAMPLESCIENTIFICTESTMAP = new HashSet<IGEN_SAMPLESCIENTIFICTESTMAP>();
            IGEN_SCIENTIFICMARKETINGMAP = new HashSet<IGEN_SCIENTIFICMARKETINGMAP>();
            IGEN_SCIENTIFICRESULT = new HashSet<IGEN_SCIENTIFICRESULT>();
            IGEN_PRODUCTTESTOVERRIDE = new HashSet<IGEN_PRODUCTTESTOVERRIDE>();
            IGEN_SCIENTIFICTESTMARKERMAP = new HashSet<IGEN_SCIENTIFICTESTMARKERMAP>();
        }

        [Key]
        public int SCIENTIFICTEST_ID { get; set; }

        public bool ACTIVE { get; set; }

        [Required]
        [StringLength(40)]
        public string NAME { get; set; }

        [Required]
        [StringLength(5)]
        public string ABBREVIATION { get; set; }

        [StringLength(40)]
        public string ALIAS { get; set; }

        [StringLength(4000)]
        public string COMMENTS { get; set; }

        public int? SUCCESSTHRESHOLD { get; set; }

        public double? GENOTYPETHRESHOLD { get; set; }

        public bool ISPARENTAGE { get; set; }

        public int? PRIORITY { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_LABSCIENTIFICTESTMAP> IGEN_LABSCIENTIFICTESTMAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MARKETINGTESTRESULTCALCULATION> IGEN_MARKETINGTESTRESULTCALCULATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_PRODUCT> IGEN_PRODUCT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_SAMPLESCIENTIFICTESTMAP> IGEN_SAMPLESCIENTIFICTESTMAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_SCIENTIFICMARKETINGMAP> IGEN_SCIENTIFICMARKETINGMAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_SCIENTIFICRESULT> IGEN_SCIENTIFICRESULT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_PRODUCTTESTOVERRIDE> IGEN_PRODUCTTESTOVERRIDE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_SCIENTIFICTESTMARKERMAP> IGEN_SCIENTIFICTESTMARKERMAP { get; set; }
    }
}
