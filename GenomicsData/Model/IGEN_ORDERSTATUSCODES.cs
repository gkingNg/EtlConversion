namespace GenomicsData.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IGEN_ORDERSTATUSCODES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_ORDERSTATUSCODES()
        {
            IGEN_ORDERSTATUS = new HashSet<IGEN_ORDERSTATUS>();
        }

        [Key]
        public int ORDERSTATUSCODES_ID { get; set; }

        public int PRIORITY { get; set; }

        [Required]
        [StringLength(255)]
        public string STATUS { get; set; }

        public DateTime dLastDWUpdate { get; set; } = DateTime.Now;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_ORDERSTATUS> IGEN_ORDERSTATUS { get; set; }
    }
}
