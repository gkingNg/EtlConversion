using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_GROUPMEMBER
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GROUP_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MEMBER_CUST_ID { get; set; }

        public bool ACTIVE { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_CUSTOMER IGEN_CUSTOMER { get; set; }

        public virtual IGEN_GROUP IGEN_GROUP { get; set; }
    }
}
