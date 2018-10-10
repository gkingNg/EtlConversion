using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_LIMS_Order_ETL_temp_Errors
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long iOrderID { get; set; }

        [StringLength(4000)]
        public string Error { get; set; }

        [StringLength(50)]
        public string sOrgName { get; set; }
    }
}
