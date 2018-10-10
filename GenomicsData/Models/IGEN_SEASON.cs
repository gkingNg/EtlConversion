using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_SEASON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_SEASON()
        {
            IGEN_CUSTOMERGOAL = new HashSet<IGEN_CUSTOMERGOAL>();
            IGEN_CUSTOMERPROGRAMPERIOD = new HashSet<IGEN_CUSTOMERPROGRAMPERIOD>();
            IGEN_IGENITYORDER = new HashSet<IGEN_IGENITYORDER>();
            IGEN_MARKETINGINDEXPERIOD = new HashSet<IGEN_MARKETINGINDEXPERIOD>();
        }

        [Key]
        public int SEASON_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string NAME { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime EFFECTIVESTARTDATE { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime EFFECTIVEENDDATE { get; set; }

        [StringLength(250)]
        public string COMMENTS { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_CUSTOMERGOAL> IGEN_CUSTOMERGOAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_CUSTOMERPROGRAMPERIOD> IGEN_CUSTOMERPROGRAMPERIOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_IGENITYORDER> IGEN_IGENITYORDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_MARKETINGINDEXPERIOD> IGEN_MARKETINGINDEXPERIOD { get; set; }
    }
}
