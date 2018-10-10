using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class igen_tempSampleStatus
    {
        public int Id { get; set; }

        public int? LIMS_iIgenityorderid { get; set; }

        [StringLength(255)]
        public string LIMS_sbarcode { get; set; }

        [StringLength(255)]
        public string LIMS_sSTStatus { get; set; }
    }
}
