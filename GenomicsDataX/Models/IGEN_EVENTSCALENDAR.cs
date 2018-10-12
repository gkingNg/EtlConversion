using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_EVENTSCALENDAR
    {
        [Key]
        public int EVENT_ID { get; set; }

        [Required]
        [StringLength(64)]
        public string TITLE { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime STARTDATE { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ENDDATE { get; set; }

        [StringLength(80)]
        public string LOCATION { get; set; }

        [StringLength(2048)]
        public string DESCRIPTION { get; set; }

        public int SUBMITTER_ID { get; set; }

        [StringLength(80)]
        public string ADMINEMAIL { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? STATUSDATE { get; set; }

        public int STATUS { get; set; }

        [StringLength(512)]
        public string REASON { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SUBMITDATE { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_LOGIN IGEN_LOGIN { get; set; }
    }
}
