using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_COMPRATE
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PRODUCT_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COMPSCHEDULE_ID { get; set; }

        public int? RATE1QTY { get; set; }

        public double RATE1AMT { get; set; }

        public int? RATE2QTY { get; set; }

        public double? RATE2AMT { get; set; }

        public int? RATE3QTY { get; set; }

        public double? RATE3AMT { get; set; }

        public double? ACCELERATORAMT { get; set; }

        public int? DECELERATORPCT { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_COMPSCHEDULE IGEN_COMPSCHEDULE { get; set; }
    }
}
