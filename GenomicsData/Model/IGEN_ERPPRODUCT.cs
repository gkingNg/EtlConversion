namespace GenomicsData.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IGEN_ERPPRODUCT : BaseIgenEntity
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


        public virtual IGEN_PRODUCT IGEN_PRODUCT { get; set; }
    }
}
