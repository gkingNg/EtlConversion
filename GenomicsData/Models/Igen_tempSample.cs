using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class Igen_tempSample
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string LIMS_sBarcode { get; set; }

        [StringLength(100)]
        public string LIMS_sMemberCode { get; set; }

        [StringLength(20)]
        public string LIMS_sHerdCode { get; set; }

        [StringLength(255)]
        public string LIMS_sBatchID { get; set; }

        public int? LIMS_iIgenityOrderID { get; set; }
    }
}
