using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_COMPPROVIDERSCHEDULE
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COMPSCHEDULE_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COMPPROVIDER_ID { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_COMPPROVIDER IGEN_COMPPROVIDER { get; set; }

        public virtual IGEN_COMPSCHEDULE IGEN_COMPSCHEDULE { get; set; }
    }
}
