using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Model
{
    public partial class IGEN_USER : BaseIgenEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_USER()
        {
            IGEN_IGENITYORDER = new HashSet<IGEN_IGENITYORDER>();

        }

        [Key]
        public int USER_ID { get; set; }

        [Required]
        [StringLength(40)]
        public string USERNAME { get; set; }

        [Required]
        [StringLength(255)]
        public string PASSWORD { get; set; }

        public bool ACTIVE { get; set; }

        [StringLength(40)]
        public string LASTNAME { get; set; }

        [StringLength(40)]
        public string FIRSTNAME { get; set; }

        [Required]
        [StringLength(40)]
        public string EMAIL { get; set; }

        [Required]
        [StringLength(80)]
        public string ROLES { get; set; }

        public int? ERP_ID { get; set; }

        public int? LAB_ID { get; set; }


 [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_IGENITYORDER> IGEN_IGENITYORDER { get; set; }


    }
}
