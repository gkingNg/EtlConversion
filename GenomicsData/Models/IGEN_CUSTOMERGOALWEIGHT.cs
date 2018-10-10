using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_CUSTOMERGOALWEIGHT
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GOAL_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MARKETINGTEST_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        public double WEIGHT { get; set; }

        [StringLength(10)]
        public string FILTERTYPE { get; set; }

        [StringLength(10)]
        public string FILTERVALUE { get; set; }

        [StringLength(10)]
        public string SORTBY { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(15)]
        public string MAPTYPE { get; set; }

        [StringLength(40)]
        public string ALIAS { get; set; }

        [Key]
        [Column(Order = 4)]
        public long SSIS_uniqueID { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_CUSTOMERGOAL IGEN_CUSTOMERGOAL { get; set; }

        public virtual IGEN_MARKETINGTEST IGEN_MARKETINGTEST { get; set; }
    }
}
