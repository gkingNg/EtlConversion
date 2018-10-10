using System;
using System.ComponentModel.DataAnnotations;

namespace GenomicsData.Models
{
    public partial class IGEN_MarketingTestResultfieldMap
    {
        public int Id { get; set; }

        public int Product_ID { get; set; }

        public int MarketingTest_ID { get; set; }

        public int LIMS_iResultFieldID { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }

        public bool? Active { get; set; }

        public DateTime? LastModifiedDateTime { get; set; }

        public virtual IGEN_MARKETINGTEST IGEN_MARKETINGTEST { get; set; }

        public virtual IGEN_PRODUCT IGEN_PRODUCT { get; set; }
    }
}
