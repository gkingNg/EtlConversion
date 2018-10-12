using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_SAMPLEPRODUCTREPORTSTATUS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SAMPLE_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PRODUCT_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int USER_ID { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "datetime2")]
        public DateTime REPORTED_DATE { get; set; }

        [Key]
        [Column(Order = 4)]
        public long SSIS_uniqueID { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_PRODUCT IGEN_PRODUCT { get; set; }

        public virtual IGEN_SAMPLE IGEN_SAMPLE { get; set; }

        public virtual IGEN_USER IGEN_USER { get; set; }
    }
}
