using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_PENDINGANIMALSTATUS
    {
        public int PENDINGANIMAL_ID { get; set; }

        [StringLength(30)]
        public string STATUS { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime STATUSDATE { get; set; }

        [StringLength(4000)]
        public string COMMENTS { get; set; }

        [Key]
        public int PENDINGANIMALSTATUS_ID { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_PENDINGANIMAL IGEN_PENDINGANIMAL { get; set; }
    }
}
