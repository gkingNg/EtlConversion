using System;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_ErrorLog
    {
        public int Id { get; set; }

        public int? ErrorNumber { get; set; }

        public int? ErrorSeverity { get; set; }

        public int? ErrorState { get; set; }

        [StringLength(100)]
        public string ErrorProcedure { get; set; }

        public int? ErrorLine { get; set; }

        public string ErrorMessage { get; set; }

        public DateTime? DateEntered { get; set; }

        public DateTime dLastDWUpdate { get; set; }
    }
}
