using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_IMPORTCHECKPOINT
    {
        [Key]
        public int CHECKPOINT_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string AREA { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime STARTDATE { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ENDDATE { get; set; }

        public int OLDID { get; set; }

        public int? NEWID { get; set; }

        public int? STATUS { get; set; }

        public int? NUMERRORS { get; set; }

        public DateTime dLastDWUpdate { get; set; }
    }
}
