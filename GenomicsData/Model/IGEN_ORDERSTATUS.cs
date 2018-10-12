namespace GenomicsData.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IGEN_ORDERSTATUS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IGENITYORDER_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ORDERSTATUSCODES_ID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "datetime2")]
        public DateTime STATUSDATE { get; set; }

        public DateTime dLastDWUpdate { get; set; } = DateTime.Now;

        public virtual IGEN_IGENITYORDER IGEN_IGENITYORDER { get; set; }

        public virtual IGEN_ORDERSTATUSCODES IGEN_ORDERSTATUSCODES { get; set; }
    }
}
