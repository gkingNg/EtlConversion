using System;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_ERPCUSTNUMBER
    {
        [Key]
        [StringLength(10)]
        public string ERPNAME { get; set; }

        public int? CURRENTNUMBER { get; set; }

        [StringLength(5)]
        public string PREFIX { get; set; }

        public DateTime dLastDWUpdate { get; set; }
    }
}
