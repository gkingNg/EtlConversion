using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_LIMS_Order_ETL_temp_LineItems
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iLineItemID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iOrderID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iProductID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iQuantity { get; set; }

        public decimal? nListPriceLI { get; set; }

        public decimal? nDiscountPercentage { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(4)]
        public string sShowResults { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iAGLBatchId { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iAGLServiceId { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string sProductName { get; set; }

        public int? PRODUCT_ID { get; set; }
    }
}
