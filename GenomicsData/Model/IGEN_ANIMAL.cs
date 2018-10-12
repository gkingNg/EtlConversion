namespace GenomicsData.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IGEN_ANIMAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_ANIMAL()
        {
            IGEN_ANIMALBREEDASSOCIATION = new HashSet<IGEN_ANIMALBREEDASSOCIATION>();
            IGEN_SAMPLE = new HashSet<IGEN_SAMPLE>();
        }

        [Key]
        public int ANIMAL_ID { get; set; }

        public int CUSTOMER_ID { get; set; }

        [StringLength(40)]
        public string ANIMALID { get; set; }

        [StringLength(40)]
        public string BREEDASSOCIATIONID { get; set; }

        [StringLength(40)]
        public string ELECTRONICID { get; set; }

        [StringLength(10)]
        public string SEX { get; set; }

        [StringLength(10)]
        public string TYPE { get; set; }

        [StringLength(10)]
        public string BREED1 { get; set; }

        [StringLength(10)]
        public string BREED2 { get; set; }

        [StringLength(10)]
        public string SIREGROUP { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? BIRTHDATE { get; set; }

        public bool SENDTOBA { get; set; }

        [StringLength(40)]
        public string ANIMALID2 { get; set; }

        public int? BIRTHSTATUS { get; set; }

        public DateTime dLastDWUpdate { get; set; } = DateTime.Now;

        public virtual IGEN_FIELDVALUES IGEN_FIELDVALUES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_ANIMALBREEDASSOCIATION> IGEN_ANIMALBREEDASSOCIATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_SAMPLE> IGEN_SAMPLE { get; set; }

        public virtual IGEN_CUSTOMER IGEN_CUSTOMER { get; set; }
    }
}
