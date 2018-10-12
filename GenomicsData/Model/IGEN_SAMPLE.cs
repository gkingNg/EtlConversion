using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace GenomicsData.Model
{
    public class IGEN_SAMPLE
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IGEN_SAMPLE()
        {
            IGEN_POTENTIALDAM = new HashSet<IGEN_POTENTIALDAM>();
            IGEN_POTENTIALDAM1 = new HashSet<IGEN_POTENTIALDAM>();
            IGEN_POTENTIALSIRE = new HashSet<IGEN_POTENTIALSIRE>();
            IGEN_POTENTIALSIRE1 = new HashSet<IGEN_POTENTIALSIRE>();
            IGEN_SAMPLEPRODUCTMAP = new HashSet<IGEN_SAMPLEPRODUCTMAP>();
        }

        [Key] public int SAMPLE_ID { get; set; }

        public int ANIMAL_ID { get; set; }

        public int IGENITYORDER_ID { get; set; }

        [Required] [StringLength(40)] public string BARCODEID { get; set; }

        [StringLength(20)] public string SUBSTRATE { get; set; }

        [StringLength(20)] public string CASENUM { get; set; }

        [StringLength(255)] public string COMMENTS { get; set; }

        [Required] [StringLength(40)] public string REFBARCODEID { get; set; }

        public bool? ISVALID { get; set; }

        [StringLength(20)] public string POSTALCODE { get; set; }

        public int? BATCHNUMBER { get; set; }

        public int? ORIGINALSAMPLE_ID { get; set; }

        [StringLength(5)] public string ISNEW { get; set; }

        [StringLength(10)] public string ABBI_TEST { get; set; }

        [StringLength(10)] public string SL_ORIGINALSAMPLE_ID { get; set; }

        public DateTime dLastDWUpdate { get; set; } = DateTime.Now;

        [StringLength(100)] public string LIMS_sMemberCode { get; set; }

        [StringLength(255)] public string LIMS_sBatchID { get; set; }

        [StringLength(100)] public string LIMS_sHerdCode { get; set; }

        [StringLength(25)] public string GeneSeekStatus { get; set; }

        [StringLength(1000)] public string CustomStatus { get; set; }

        [StringLength(100)] public string LIMS_sSire1 { get; set; }

        public virtual IGEN_ANIMAL IGEN_ANIMAL { get; set; }

        public virtual IGEN_IGENITYORDER IGEN_IGENITYORDER { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_POTENTIALDAM> IGEN_POTENTIALDAM { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_POTENTIALDAM> IGEN_POTENTIALDAM1 { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_POTENTIALSIRE> IGEN_POTENTIALSIRE { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_POTENTIALSIRE> IGEN_POTENTIALSIRE1 { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IGEN_SAMPLEPRODUCTMAP> IGEN_SAMPLEPRODUCTMAP { get; set; }
    }
}