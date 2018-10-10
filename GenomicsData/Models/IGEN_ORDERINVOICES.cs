using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_ORDERINVOICES
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IGENITYORDER_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string INVOICEID { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_IGENITYORDER IGEN_IGENITYORDER { get; set; }
    }
}
