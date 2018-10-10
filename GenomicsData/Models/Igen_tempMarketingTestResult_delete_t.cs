using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class Igen_tempMarketingTestResult_delete_t
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string LIMS_sResult { get; set; }

        public int? LIMS_iIgenityOrderID { get; set; }

        [StringLength(255)]
        public string LIMS_sBarcode { get; set; }

        public long? LIMS_iProductID { get; set; }

        public long? LIMS_iResultFieldID { get; set; }
    }
}
