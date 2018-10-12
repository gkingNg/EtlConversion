using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_PRODUCTMARKETINGTESTMAP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MARKETINGTEST_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PRODUCT_ID { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_MARKETINGTEST IGEN_MARKETINGTEST { get; set; }

        public virtual IGEN_PRODUCT IGEN_PRODUCT { get; set; }
    }
}
