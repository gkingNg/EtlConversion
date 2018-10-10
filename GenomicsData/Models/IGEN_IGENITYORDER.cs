using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_IGENITYORDER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_IGENITYORDER()
        {
            IGEN_ORDERINVOICES = new HashSet<IGEN_ORDERINVOICES>();
            IGEN_ORDERSTATUS = new HashSet<IGEN_ORDERSTATUS>();
            IGEN_SAMPLE = new HashSet<IGEN_SAMPLE>();
            IGEN_PAYMENTTRANSACTION = new HashSet<IGEN_PAYMENTTRANSACTION>();
        }

        [Key]
        public int IGENITYORDER_ID { get; set; }

        public int LAB_ID { get; set; }

        public int CUSTOMER_ID { get; set; }

        public int USER_ID { get; set; }

        public int? COMPSALESREP_ID { get; set; }

        public bool? DECELERATOR { get; set; }

        public double? CHECKAMOUNT { get; set; }

        [StringLength(20)]
        public string CHECKNUMBER { get; set; }

        public int PRIORITY { get; set; }

        [Required]
        [StringLength(20)]
        public string ORDERTYPE { get; set; }

        [StringLength(20)]
        public string MASTERORDERID { get; set; }

        [Required]
        [StringLength(20)]
        public string PAYMENTTYPE { get; set; }

        [StringLength(20)]
        public string PAYMENTREFERENCE { get; set; }

        [StringLength(250)]
        public string COMMENTS { get; set; }

        public int? REDOORDERID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? EMAILRECEIVED_DATE { get; set; }

        public int? SEASON_ID { get; set; }

        public int? LAB_ORDERID { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_COMPSALESREP IGEN_COMPSALESREP { get; set; }

        public virtual IGEN_CUSTOMER IGEN_CUSTOMER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_ORDERINVOICES> IGEN_ORDERINVOICES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_ORDERSTATUS> IGEN_ORDERSTATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_SAMPLE> IGEN_SAMPLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_PAYMENTTRANSACTION> IGEN_PAYMENTTRANSACTION { get; set; }

        public virtual IGEN_LAB IGEN_LAB { get; set; }

        public virtual IGEN_SEASON IGEN_SEASON { get; set; }

        public virtual IGEN_USER IGEN_USER { get; set; }
    }
}
