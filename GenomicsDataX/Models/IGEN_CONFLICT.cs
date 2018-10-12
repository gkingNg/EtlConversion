using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_CONFLICT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_CONFLICT()
        {
            IGEN_CONFLICTDETAILS = new HashSet<IGEN_CONFLICTDETAILS>();
        }

        public int ID { get; set; }

        public int LabId { get; set; }

        [Required]
        [StringLength(40)]
        public string ID18 { get; set; }

        [Required]
        [StringLength(40)]
        public string BarcodeID { get; set; }

        [StringLength(255)]
        public string AnimalName { get; set; }

        public DateTime? SampleDate { get; set; }

        public DateTime? Created { get; set; }

        public DateTime LastModified { get; set; }

        public bool? Active { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_CONFLICTDETAILS> IGEN_CONFLICTDETAILS { get; set; }

        public virtual IGEN_LAB IGEN_LAB { get; set; }
    }
}
