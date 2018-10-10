using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_LOGIN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_LOGIN()
        {
            IGEN_CUSTOMERLOGIN = new HashSet<IGEN_CUSTOMERLOGIN>();
            IGEN_EVENTSCALENDAR = new HashSet<IGEN_EVENTSCALENDAR>();
            IGEN_SORTFILTER = new HashSet<IGEN_SORTFILTER>();
        }

        [Key]
        public int LOGIN_ID { get; set; }

        [Required]
        [StringLength(80)]
        public string EMAIL { get; set; }

        [Required]
        [StringLength(32)]
        public string PASSWORD { get; set; }

        [Required]
        [StringLength(40)]
        public string QUESTION { get; set; }

        [Required]
        [StringLength(40)]
        public string ANSWER { get; set; }

        public bool ACTIVE { get; set; }

        [StringLength(40)]
        public string FIRSTNAME { get; set; }

        [StringLength(40)]
        public string LASTNAME { get; set; }

        [StringLength(20)]
        public string PHONE1 { get; set; }

        [StringLength(20)]
        public string FAX { get; set; }

        [StringLength(40)]
        public string OPERATIONNAME { get; set; }

        [StringLength(80)]
        public string ADDRESS1 { get; set; }

        [StringLength(80)]
        public string ADDRESS2 { get; set; }

        [StringLength(40)]
        public string CITY { get; set; }

        [StringLength(20)]
        public string STATE { get; set; }

        [StringLength(20)]
        public string ZIP { get; set; }

        public bool? PRIMARYBEEF { get; set; }

        public bool? PRIMARYDAIRY { get; set; }

        public int? PERCENT_AI { get; set; }

        public bool? BREEDSYNC { get; set; }

        public int? DAIRYCOWS { get; set; }

        public int? DAIRYHEIFERS { get; set; }

        public int? DAIRYCALVES { get; set; }

        public int? DAIRYVEALCALVES { get; set; }

        public int? DAIRYFED { get; set; }

        public int? BEEFCOWS { get; set; }

        public int? BEEFHEIFERS { get; set; }

        public int? WEANEDCALVES { get; set; }

        public int? STOCKERCATTLE { get; set; }

        public int? FEEDERCATTLE { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SUBMIT_DATE { get; set; }

        [StringLength(80)]
        public string ACTIVEREASON { get; set; }

        [StringLength(200)]
        public string WEBSITE { get; set; }

        public string EXTRADATA { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_CUSTOMERLOGIN> IGEN_CUSTOMERLOGIN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_EVENTSCALENDAR> IGEN_EVENTSCALENDAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_SORTFILTER> IGEN_SORTFILTER { get; set; }
    }
}
