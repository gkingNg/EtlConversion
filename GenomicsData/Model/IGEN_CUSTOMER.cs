namespace GenomicsData.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IGEN_CUSTOMER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_CUSTOMER()
        {
            IGEN_ANIMAL = new HashSet<IGEN_ANIMAL>();
            IGEN_IGENITYORDER = new HashSet<IGEN_IGENITYORDER>();
            IGEN_CUSTOMERBREEDASSOCIATION = new HashSet<IGEN_CUSTOMERBREEDASSOCIATION>();
        }

        [Key]
        public int CUSTOMER_ID { get; set; }

        public int ERP_ID { get; set; }

        public int? COMPSALESREP_ID { get; set; }

        [StringLength(80)]
        public string SHIPTO { get; set; }

        [StringLength(80)]
        public string BILLTO { get; set; }

        [Required]
        [StringLength(80)]
        public string ACCOUNTNAME { get; set; }

        [StringLength(40)]
        public string CONTACTLASTNAME { get; set; }

        [StringLength(40)]
        public string CONTACTFIRSTNAME { get; set; }

        [StringLength(40)]
        public string ADDRESSLINE1 { get; set; }

        [StringLength(40)]
        public string ADDRESSLINE2 { get; set; }

        [StringLength(40)]
        public string CITY { get; set; }

        [StringLength(20)]
        public string STATE { get; set; }

        [StringLength(20)]
        public string POSTALCODE { get; set; }

        [StringLength(40)]
        public string COUNTRY { get; set; }

        [StringLength(20)]
        public string PHONE1 { get; set; }

        [StringLength(20)]
        public string PHONE2 { get; set; }

        [StringLength(20)]
        public string PHONE3 { get; set; }

        [StringLength(20)]
        public string FAX { get; set; }

        [StringLength(80)]
        public string EMAIL { get; set; }

        [StringLength(10)]
        public string BREEDASSOCIATIONBREED { get; set; }

        [StringLength(40)]
        public string BREEDASSOCIATIONID { get; set; }

        public bool? FAXRESULTS { get; set; }

        public bool? MAILRESULTS { get; set; }

        public bool? EMAILRESULTS { get; set; }

        [StringLength(20)]
        public string HERDCODE { get; set; }

        [StringLength(80)]
        public string EMAIL1 { get; set; }

        [StringLength(250)]
        public string COMMENTS { get; set; }

        public bool? DAIRYCOMP { get; set; }

        [StringLength(200)]
        public string WEBSITE { get; set; }

        public bool TRACKRESULT { get; set; }

        public bool ISSIGNATURE { get; set; }

        public DateTime dLastDWUpdate { get; set; } = DateTime.Now;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_ANIMAL> IGEN_ANIMAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_IGENITYORDER> IGEN_IGENITYORDER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_CUSTOMERBREEDASSOCIATION> IGEN_CUSTOMERBREEDASSOCIATION { get; set; }
    }
}
