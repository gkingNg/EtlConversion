using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_PRODUCTLOCALE
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PRODUCT_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LOCALE_ID { get; set; }

        [Required]
        [StringLength(40)]
        public string NAME { get; set; }

        [Required]
        [StringLength(5)]
        public string ABBREVIATION { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_LOCALE IGEN_LOCALE { get; set; }

        public virtual IGEN_PRODUCT IGEN_PRODUCT { get; set; }
    }
}
