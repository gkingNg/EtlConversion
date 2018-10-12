using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class IGEN_ANIMALBREEDASSOCIATION
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ANIMAL_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string BREEDASSOCIATIONCODE { get; set; }

        [StringLength(40)]
        public string REGISTRATIONNUMBER { get; set; }

        [StringLength(20)]
        public string CASENUM { get; set; }

        public int? CUSTOMERBREEDASSOC_ID { get; set; }

        public DateTime dLastDWUpdate { get; set; }

        public virtual IGEN_ANIMAL IGEN_ANIMAL { get; set; }

        public virtual IGEN_CUSTOMERBREEDASSOCIATION IGEN_CUSTOMERBREEDASSOCIATION { get; set; }
    }
}
