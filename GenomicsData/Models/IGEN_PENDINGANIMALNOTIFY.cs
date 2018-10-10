using System;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_PENDINGANIMALNOTIFY
    {
        public int PENDINGANIMAL_ID { get; set; }

        [StringLength(50)]
        public string NOTIFY_NAME { get; set; }

        [StringLength(50)]
        public string NOTIFY_EMAIL { get; set; }

        public bool ISOWNER { get; set; }

        [Key]
        public int PENDINGANIMALNOTIFY_ID { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_PENDINGANIMAL IGEN_PENDINGANIMAL { get; set; }
    }
}
