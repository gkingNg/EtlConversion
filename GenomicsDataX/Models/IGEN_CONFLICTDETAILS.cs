using System;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_CONFLICTDETAILS
    {
        public int ID { get; set; }

        public int? ConflictID { get; set; }

        [Required]
        [StringLength(40)]
        public string IDValue { get; set; }

        public int? CodeID { get; set; }

        public DateTime? Created { get; set; }

        public DateTime LastModified { get; set; }

        public bool? Active { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual C_IgenityTest___dbo___IGEN_CONFLICTCODE_Old_ C_IgenityTest___dbo___IGEN_CONFLICTCODE_Old_ { get; set; }

        public virtual IGEN_CONFLICT IGEN_CONFLICT { get; set; }
    }
}
