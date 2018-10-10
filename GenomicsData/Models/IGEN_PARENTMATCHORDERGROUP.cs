using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_PARENTMATCHORDERGROUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_PARENTMATCHORDERGROUP()
        {
            IGEN_PARENTMATCHORDER = new HashSet<IGEN_PARENTMATCHORDER>();
        }

        [Key]
        public int PARENTMATCHORDERGROUP_ID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ORDER_DATE { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? RESULT_DATE { get; set; }

        [Required]
        [StringLength(2)]
        public string TYPE { get; set; }

        public string EXPORT_CRITERIA { get; set; }

        public bool PUBLISH { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_PARENTMATCHORDER> IGEN_PARENTMATCHORDER { get; set; }
    }
}
