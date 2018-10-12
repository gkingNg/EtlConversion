using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_SCORE
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MARKETINGTEST_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string MARKETINGRESULT { get; set; }

        [Required]
        [StringLength(30)]
        public string RAWVALUE { get; set; }

        [StringLength(40)]
        public string RAWVALUEUOM { get; set; }

        public DateTime dLastDWUpdate { get; set; }
    }
}
