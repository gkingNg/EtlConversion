using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_ERPPRODUCT
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PRODUCT_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ERP_ID { get; set; }

        [Required]
        [StringLength(40)]
        public string ERPPRODUCTID { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_ERP IGEN_ERP { get; set; }

        public virtual IGEN_PRODUCT IGEN_PRODUCT { get; set; }
    }
}
