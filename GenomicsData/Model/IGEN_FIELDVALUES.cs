namespace GenomicsData.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IGEN_FIELDVALUES : BaseIgenEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_FIELDVALUES()
        {
            IGEN_ANIMAL = new HashSet<IGEN_ANIMAL>();
        }

        public int ID { get; set; }

        public bool ACTIVE { get; set; }

        [Required]
        [StringLength(25)]
        public string FIELD { get; set; }

        [Required]
        [StringLength(50)]
        public string FIELDVALUE { get; set; }

        public byte? SORTORDER { get; set; }

        [StringLength(255)]
        public string FIELDDEFINITION { get; set; }

        [StringLength(50)]
        public string PARENTFIELD { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_ANIMAL> IGEN_ANIMAL { get; set; }
    }
}
