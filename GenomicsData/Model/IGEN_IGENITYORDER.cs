using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Model
{
    public partial class IGEN_IGENITYORDER : BaseIgenEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_IGENITYORDER()
        {
            IGEN_ORDERSTATUS = new HashSet<IGEN_ORDERSTATUS>();
            IGEN_SAMPLE = new HashSet<IGEN_SAMPLE>();
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




        public virtual IGEN_CUSTOMER IGEN_CUSTOMER { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_ORDERSTATUS> IGEN_ORDERSTATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_SAMPLE> IGEN_SAMPLE { get; set; }

        public virtual IGEN_LAB IGEN_LAB { get; set; }


        public virtual IGEN_USER IGEN_USER { get; set; }
    }
}
