using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_PAYMENTTRANSACTION
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int USER_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CUSTOMER_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string PAYMENT_REF { get; set; }

        public int? IGENITYORDER_ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string TRAX_TYPE { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "datetime2")]
        public DateTime TRAX_DATE { get; set; }

        [StringLength(100)]
        public string TRAX_REFERENCE { get; set; }

        [StringLength(255)]
        public string TRAX_COMMENTS { get; set; }

        public double? TRAX_AMOUNT { get; set; }

        [Key]
        [Column(Order = 5)]
        public long SSIS_uniqueID { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_CUSTOMER IGEN_CUSTOMER { get; set; }

        public virtual IGEN_IGENITYORDER IGEN_IGENITYORDER { get; set; }

        public virtual IGEN_USER IGEN_USER { get; set; }
    }
}
