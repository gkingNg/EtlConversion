using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_CONFLICTCODEX
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string Code { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1000)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1000)]
        public string Meaning { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1000)]
        public string Correction { get; set; }

        [StringLength(1000)]
        public string GeneseekResponse { get; set; }

        public DateTime? Created { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime LastModified { get; set; }

        [StringLength(500)]
        public string CustomerActionUSBreed { get; set; }

        [StringLength(500)]
        public string CustomerActionNonUSBreed { get; set; }

        public bool? Active { get; set; }

        [StringLength(500)]
        public string CustomerAction { get; set; }

        public bool? TerminalConflict { get; set; }

        public int? Priority { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime dLastDWUpdate { get; set; }
    }
}
