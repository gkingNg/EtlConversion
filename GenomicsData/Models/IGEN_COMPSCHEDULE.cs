using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_COMPSCHEDULE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_COMPSCHEDULE()
        {
            IGEN_COMPPROVIDERSCHEDULE = new HashSet<IGEN_COMPPROVIDERSCHEDULE>();
            IGEN_COMPRATE = new HashSet<IGEN_COMPRATE>();
        }

        [Key]
        public int COMPSCHEDULE_ID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime STARTDATE { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ENDDATE { get; set; }

        [StringLength(80)]
        public string DESCRIPTION { get; set; }

        [Required]
        [StringLength(10)]
        public string ALGORITHM { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_COMPPROVIDERSCHEDULE> IGEN_COMPPROVIDERSCHEDULE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_COMPRATE> IGEN_COMPRATE { get; set; }
    }
}
