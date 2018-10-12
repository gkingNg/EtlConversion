using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_CUSTOMERLOGIN
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CUSTOMER_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOGIN_ID { get; set; }

        public bool? VALIDATED { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_CUSTOMER IGEN_CUSTOMER { get; set; }

        public virtual IGEN_LOGIN IGEN_LOGIN { get; set; }
    }
}
