using System;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_ForResultCalculations
    {
        [Key]
        public int RowId { get; set; }

        public int? Id { get; set; }

        [StringLength(25)]
        public string Description { get; set; }

        [StringLength(25)]
        public string Type { get; set; }

        [StringLength(10)]
        public string Formulae { get; set; }

        public DateTime dLastDWUpdate { get; set; }
    }
}
