using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_breed
    {
        [StringLength(10)]
        public string BREED { get; set; }

        [StringLength(20)]
        public string BREEDASSOCIATIONCODE { get; set; }

        [StringLength(100)]
        public string BREED_NAME { get; set; }

        [StringLength(100)]
        public string BREEDASSOC_NAME { get; set; }

        public int? PRIORITY { get; set; }

        [StringLength(40)]
        public string GACONTACTFIRSTNAME { get; set; }

        [StringLength(40)]
        public string GACONTACTLASTNAME { get; set; }

        [StringLength(80)]
        public string GACONTACTEMAIL { get; set; }

        [Key]
        [Column(Order = 0)]
        public int BREED_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime dLastDWUpdate { get; set; }
    }
}
