

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Model
{
    public partial class IGEN_SAMPLEPRODUCTMAP : BaseIgenEntity
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PRODUCT_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SAMPLE_ID { get; set; }


        public virtual IGEN_PRODUCT IGEN_PRODUCT { get; set; }

        public virtual IGEN_SAMPLE IGEN_SAMPLE { get; set; }
    }
}
