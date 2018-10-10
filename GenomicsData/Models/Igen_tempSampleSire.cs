using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class Igen_tempSampleSire
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string LIMS_sBarcode { get; set; }

        [StringLength(100)]
        public string LIMS_sSire1 { get; set; }
    }
}
