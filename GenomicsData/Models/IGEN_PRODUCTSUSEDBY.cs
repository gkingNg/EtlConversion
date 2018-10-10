using System;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_PRODUCTSUSEDBY
    {
        public int ID { get; set; }

        public long? UsedByID { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        public bool? Active { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_LIMSGENOMICPRODUCTSCIENTIFICTESTMAP IGEN_LIMSGENOMICPRODUCTSCIENTIFICTESTMAP { get; set; }
    }
}
