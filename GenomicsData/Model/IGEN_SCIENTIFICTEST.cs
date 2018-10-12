namespace GenomicsData.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IGEN_SCIENTIFICTEST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_SCIENTIFICTEST()
        {
            IGEN_PRODUCT = new HashSet<IGEN_PRODUCT>();
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

        public DateTime dLastDWUpdate { get; set; } = DateTime.Now;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_PRODUCT> IGEN_PRODUCT { get; set; }
    }
}
