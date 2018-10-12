using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    [Table("[[IgenityTest].[dbo].[IGEN_CONFLICTCODE_Old]]")]
    public partial class C_IgenityTest___dbo___IGEN_CONFLICTCODE_Old_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_IgenityTest___dbo___IGEN_CONFLICTCODE_Old_()
        {
            IGEN_CONFLICTDETAILS = new HashSet<IGEN_CONFLICTDETAILS>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(3)]
        public string Code { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        [StringLength(1000)]
        public string Meaning { get; set; }

        [Required]
        [StringLength(1000)]
        public string Correction { get; set; }

        [StringLength(1000)]
        public string GeneseekResponse { get; set; }

        public DateTime? Created { get; set; }

        public DateTime LastModified { get; set; }

        [StringLength(500)]
        public string CustomerActionUSBreed { get; set; }

        [StringLength(500)]
        public string CustomerActionNonUSBreed { get; set; }

        public bool? Active { get; set; }

        [StringLength(500)]
        public string CustomerAction { get; set; }

        public bool? TerminalConflict { get; set; }

        public int? Priority { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_CONFLICTDETAILS> IGEN_CONFLICTDETAILS { get; set; }
    }
}
