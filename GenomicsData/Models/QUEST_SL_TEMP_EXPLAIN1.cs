using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class QUEST_SL_TEMP_EXPLAIN1
    {
        [StringLength(30)]
        public string STATEMENT_ID { get; set; }

        public double? PLAN_ID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? TIMESTAMP { get; set; }

        [StringLength(80)]
        public string REMARKS { get; set; }

        [StringLength(30)]
        public string OPERATION { get; set; }

        [StringLength(255)]
        public string OPTIONS { get; set; }

        [StringLength(128)]
        public string OBJECT_NODE { get; set; }

        [StringLength(30)]
        public string OBJECT_OWNER { get; set; }

        [StringLength(30)]
        public string OBJECT_NAME { get; set; }

        [StringLength(65)]
        public string OBJECT_ALIAS { get; set; }

        public double? OBJECT_INSTANCE { get; set; }

        [StringLength(30)]
        public string OBJECT_TYPE { get; set; }

        [StringLength(255)]
        public string OPTIMIZER { get; set; }

        public double? SEARCH_COLUMNS { get; set; }

        public double? ID { get; set; }

        public double? PARENT_ID { get; set; }

        public double? DEPTH { get; set; }

        public double? POSITION { get; set; }

        public double? COST { get; set; }

        public double? CARDINALITY { get; set; }

        public double? BYTES { get; set; }

        [StringLength(255)]
        public string OTHER_TAG { get; set; }

        [StringLength(255)]
        public string PARTITION_START { get; set; }

        [StringLength(255)]
        public string PARTITION_STOP { get; set; }

        public double? PARTITION_ID { get; set; }

        public string OTHER { get; set; }

        [StringLength(30)]
        public string DISTRIBUTION { get; set; }

        public int? CPU_COST { get; set; }

        public int? IO_COST { get; set; }

        public int? TEMP_SPACE { get; set; }

        [StringLength(4000)]
        public string ACCESS_PREDICATES { get; set; }

        [StringLength(4000)]
        public string FILTER_PREDICATES { get; set; }

        [Key]
        [Column(Order = 0)]
        public long SSIS_uniqueID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime dLastDWUpdate { get; set; }
    }
}
