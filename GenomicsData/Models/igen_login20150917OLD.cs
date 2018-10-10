using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenomicsData.Models
{
    public partial class igen_login20150917OLD
    {
        [Key]
        [Column(Order = 0)]
        public int LOGIN_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(80)]
        public string EMAIL { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(32)]
        public string PASSWORD { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(40)]
        public string QUESTION { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(40)]
        public string ANSWER { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool ACTIVE { get; set; }

        [StringLength(40)]
        public string FIRSTNAME { get; set; }

        [StringLength(40)]
        public string LASTNAME { get; set; }

        [StringLength(20)]
        public string PHONE1 { get; set; }

        [StringLength(20)]
        public string FAX { get; set; }

        [StringLength(40)]
        public string OPERATIONNAME { get; set; }

        [StringLength(80)]
        public string ADDRESS1 { get; set; }

        [StringLength(80)]
        public string ADDRESS2 { get; set; }

        [StringLength(40)]
        public string CITY { get; set; }

        [StringLength(20)]
        public string STATE { get; set; }

        [StringLength(20)]
        public string ZIP { get; set; }

        public bool? PRIMARYBEEF { get; set; }

        public bool? PRIMARYDAIRY { get; set; }

        public int? PERCENT_AI { get; set; }

        public bool? BREEDSYNC { get; set; }

        public int? DAIRYCOWS { get; set; }

        public int? DAIRYHEIFERS { get; set; }

        public int? DAIRYCALVES { get; set; }

        public int? DAIRYVEALCALVES { get; set; }

        public int? DAIRYFED { get; set; }

        public int? BEEFCOWS { get; set; }

        public int? BEEFHEIFERS { get; set; }

        public int? WEANEDCALVES { get; set; }

        public int? STOCKERCATTLE { get; set; }

        public int? FEEDERCATTLE { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "datetime2")]
        public DateTime SUBMIT_DATE { get; set; }

        [StringLength(80)]
        public string ACTIVEREASON { get; set; }

        [StringLength(200)]
        public string WEBSITE { get; set; }

        public string EXTRADATA { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime dLastDWUpdate { get; set; }
    }
}
