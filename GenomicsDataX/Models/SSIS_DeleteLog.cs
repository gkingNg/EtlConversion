using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class SSIS_DeleteLog
    {
        [Key]
        [Column(Order = 0)]
        public long SSISDeleteUniqueID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string SchemaName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(250)]
        public string TableName { get; set; }

        [StringLength(500)]
        public string KeyColumn { get; set; }

        [StringLength(500)]
        public string KeyID1 { get; set; }

        [StringLength(500)]
        public string KeyID2 { get; set; }

        [StringLength(500)]
        public string KeyID3 { get; set; }

        [StringLength(500)]
        public string KeyID4 { get; set; }

        [StringLength(500)]
        public string KeyID5 { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime DeletedDate { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime dLastDWUpdate { get; set; }
    }
}
