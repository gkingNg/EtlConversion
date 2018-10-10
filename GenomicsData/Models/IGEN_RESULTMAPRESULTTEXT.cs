using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_RESULTMAPRESULTTEXT
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RESULTMAPRESULT_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string RESULTTEXT { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_RESULTMAPRESULT IGEN_RESULTMAPRESULT { get; set; }
    }
}
