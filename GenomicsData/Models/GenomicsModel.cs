using System.Data.Entity;

namespace GenomicsData.Models
{
    public partial class GenomicsModel : DbContext
    {
        public GenomicsModel()
            : base("name=GenomicsModel")
        {
        }

        public virtual DbSet<C_IgenityTest___dbo___IGEN_CONFLICTCODE_Old_> C_IgenityTest___dbo___IGEN_CONFLICTCODE_Old_ { get; set; }
        public virtual DbSet<IGEN_ABMAPPING> IGEN_ABMAPPING { get; set; }
        public virtual DbSet<IGEN_ANIMAL> IGEN_ANIMAL { get; set; }
        public virtual DbSet<IGEN_ANIMALBREEDASSOCIATION> IGEN_ANIMALBREEDASSOCIATION { get; set; }
        public virtual DbSet<IGEN_breed_old> IGEN_breed_old { get; set; }
        public virtual DbSet<IGEN_COMPPROVIDER> IGEN_COMPPROVIDER { get; set; }
        public virtual DbSet<IGEN_COMPPROVIDERSCHEDULE> IGEN_COMPPROVIDERSCHEDULE { get; set; }
        public virtual DbSet<IGEN_COMPRATE> IGEN_COMPRATE { get; set; }
        public virtual DbSet<IGEN_COMPSALESREP> IGEN_COMPSALESREP { get; set; }
        public virtual DbSet<IGEN_COMPSCHEDULE> IGEN_COMPSCHEDULE { get; set; }
        public virtual DbSet<IGEN_CONFIG_old> IGEN_CONFIG_old { get; set; }
        public virtual DbSet<IGEN_CONFLICT> IGEN_CONFLICT { get; set; }
        public virtual DbSet<IGEN_CONFLICTDETAILS> IGEN_CONFLICTDETAILS { get; set; }
        public virtual DbSet<IGEN_CUSTOMER> IGEN_CUSTOMER { get; set; }
        public virtual DbSet<IGEN_CUSTOMERBREEDASSOCIATION> IGEN_CUSTOMERBREEDASSOCIATION { get; set; }
        public virtual DbSet<IGEN_CUSTOMERGOAL> IGEN_CUSTOMERGOAL { get; set; }
        public virtual DbSet<IGEN_CUSTOMERLOGIN> IGEN_CUSTOMERLOGIN { get; set; }
        public virtual DbSet<IGEN_CUSTOMERPROGRAMPERIOD> IGEN_CUSTOMERPROGRAMPERIOD { get; set; }
        public virtual DbSet<IGEN_CUSTOMINDEXMAP> IGEN_CUSTOMINDEXMAP { get; set; }
        public virtual DbSet<IGEN_DAMEXCLUDEDMARKER> IGEN_DAMEXCLUDEDMARKER { get; set; }
        public virtual DbSet<IGEN_ERP> IGEN_ERP { get; set; }
        public virtual DbSet<IGEN_ERPCUSTNUMBER> IGEN_ERPCUSTNUMBER { get; set; }
        public virtual DbSet<IGEN_ERPPRODUCT> IGEN_ERPPRODUCT { get; set; }
        public virtual DbSet<IGEN_ErrorLog> IGEN_ErrorLog { get; set; }
        public virtual DbSet<IGEN_EVENTSCALENDAR> IGEN_EVENTSCALENDAR { get; set; }
        public virtual DbSet<IGEN_FIELDVALUES> IGEN_FIELDVALUES { get; set; }
        public virtual DbSet<IGEN_FILTER> IGEN_FILTER { get; set; }
        public virtual DbSet<IGEN_ForResultCalculations> IGEN_ForResultCalculations { get; set; }
        public virtual DbSet<IGEN_GROUP> IGEN_GROUP { get; set; }
        public virtual DbSet<IGEN_GROUPMEMBER> IGEN_GROUPMEMBER { get; set; }
        public virtual DbSet<IGEN_IGENITYORDER> IGEN_IGENITYORDER { get; set; }
        public virtual DbSet<IGEN_IMPORTCHECKPOINT> IGEN_IMPORTCHECKPOINT { get; set; }
        public virtual DbSet<IGEN_LAB> IGEN_LAB { get; set; }
        public virtual DbSet<IGEN_LABSCIENTIFICTESTMAP> IGEN_LABSCIENTIFICTESTMAP { get; set; }
        public virtual DbSet<IGEN_LIMSGENOMICPRODUCTSCIENTIFICTESTMAP> IGEN_LIMSGENOMICPRODUCTSCIENTIFICTESTMAP { get; set; }
        public virtual DbSet<IGEN_LOCALE> IGEN_LOCALE { get; set; }
        public virtual DbSet<IGEN_LOGIN> IGEN_LOGIN { get; set; }
        public virtual DbSet<IGEN_MARKER> IGEN_MARKER { get; set; }
        public virtual DbSet<IGEN_MARKERALIAS> IGEN_MARKERALIAS { get; set; }
        public virtual DbSet<IGEN_MARKERMICROSAT> IGEN_MARKERMICROSAT { get; set; }
        public virtual DbSet<IGEN_MARKERPERIODMARKERMAP> IGEN_MARKERPERIODMARKERMAP { get; set; }
        public virtual DbSet<IGEN_MARKETINGINDEXPERIOD> IGEN_MARKETINGINDEXPERIOD { get; set; }
        public virtual DbSet<IGEN_MARKETINGMARKERSPERIOD> IGEN_MARKETINGMARKERSPERIOD { get; set; }
        public virtual DbSet<IGEN_MARKETINGTEST> IGEN_MARKETINGTEST { get; set; }
        public virtual DbSet<IGEN_MARKETINGTESTGROUP> IGEN_MARKETINGTESTGROUP { get; set; }
        public virtual DbSet<IGEN_MARKETINGTESTGROUPLOCALE> IGEN_MARKETINGTESTGROUPLOCALE { get; set; }
        public virtual DbSet<IGEN_MARKETINGTESTGROUPTESTMAP> IGEN_MARKETINGTESTGROUPTESTMAP { get; set; }
        public virtual DbSet<IGEN_MARKETINGTESTLOCALE> IGEN_MARKETINGTESTLOCALE { get; set; }
        public virtual DbSet<IGEN_MARKETINGTESTRESULT> IGEN_MARKETINGTESTRESULT { get; set; }
        public virtual DbSet<IGEN_MARKETINGTESTRESULTCALCULATION> IGEN_MARKETINGTESTRESULTCALCULATION { get; set; }
        public virtual DbSet<IGEN_MarketingTestResultfieldMap> IGEN_MarketingTestResultfieldMap { get; set; }
        public virtual DbSet<IGEN_ORDERINVOICES> IGEN_ORDERINVOICES { get; set; }
        public virtual DbSet<IGEN_ORDERKIT> IGEN_ORDERKIT { get; set; }
        public virtual DbSet<IGEN_ORDERSTATUS> IGEN_ORDERSTATUS { get; set; }
        public virtual DbSet<IGEN_ORDERSTATUSCODES> IGEN_ORDERSTATUSCODES { get; set; }
        public virtual DbSet<IGEN_PARENTMATCHORDER> IGEN_PARENTMATCHORDER { get; set; }
        public virtual DbSet<IGEN_PARENTMATCHORDERGROUP> IGEN_PARENTMATCHORDERGROUP { get; set; }
        public virtual DbSet<IGEN_PENDINGANIMAL> IGEN_PENDINGANIMAL { get; set; }
        public virtual DbSet<IGEN_PENDINGANIMALNOTIFY> IGEN_PENDINGANIMALNOTIFY { get; set; }
        public virtual DbSet<IGEN_PENDINGANIMALSTATUS> IGEN_PENDINGANIMALSTATUS { get; set; }
        public virtual DbSet<IGEN_PERCENTILERANGE> IGEN_PERCENTILERANGE { get; set; }
        public virtual DbSet<IGEN_POTENTIALDAM> IGEN_POTENTIALDAM { get; set; }
        public virtual DbSet<IGEN_POTENTIALSIRE> IGEN_POTENTIALSIRE { get; set; }
        public virtual DbSet<IGEN_PRODUCT> IGEN_PRODUCT { get; set; }
        public virtual DbSet<IGEN_PRODUCTLOCALE> IGEN_PRODUCTLOCALE { get; set; }
        public virtual DbSet<IGEN_PRODUCTMARKETINGTESTMAP> IGEN_PRODUCTMARKETINGTESTMAP { get; set; }
        public virtual DbSet<IGEN_PRODUCTSUSEDBY> IGEN_PRODUCTSUSEDBY { get; set; }
        public virtual DbSet<IGEN_PROGRAM> IGEN_PROGRAM { get; set; }
        public virtual DbSet<IGEN_PROSPECT> IGEN_PROSPECT { get; set; }
        public virtual DbSet<IGEN_RESULTDIRECTEFFECT> IGEN_RESULTDIRECTEFFECT { get; set; }
        public virtual DbSet<IGEN_RESULTDIRECTEFFECTSCORE> IGEN_RESULTDIRECTEFFECTSCORE { get; set; }
        public virtual DbSet<IGEN_RESULTEFFECT> IGEN_RESULTEFFECT { get; set; }
        public virtual DbSet<IGEN_RESULTEFFECTMARKER> IGEN_RESULTEFFECTMARKER { get; set; }
        public virtual DbSet<IGEN_RESULTEFFECTSCORE> IGEN_RESULTEFFECTSCORE { get; set; }
        public virtual DbSet<IGEN_RESULTMAP> IGEN_RESULTMAP { get; set; }
        public virtual DbSet<IGEN_RESULTMAPRESULT> IGEN_RESULTMAPRESULT { get; set; }
        public virtual DbSet<IGEN_RESULTMAPRESULTMARKER> IGEN_RESULTMAPRESULTMARKER { get; set; }
        public virtual DbSet<IGEN_RESULTMAPRESULTTEXT> IGEN_RESULTMAPRESULTTEXT { get; set; }
        public virtual DbSet<IGEN_SAMPLE> IGEN_SAMPLE { get; set; }
        public virtual DbSet<IGEN_SAMPLEEXTENDED> IGEN_SAMPLEEXTENDED { get; set; }
        public virtual DbSet<IGEN_SAMPLELABETA> IGEN_SAMPLELABETA { get; set; }
        public virtual DbSet<IGEN_SAMPLEPRODUCTMAP> IGEN_SAMPLEPRODUCTMAP { get; set; }
        public virtual DbSet<IGEN_SAMPLERESULTSMAP> IGEN_SAMPLERESULTSMAP { get; set; }
        public virtual DbSet<IGEN_SAMPLESCIENTIFICTESTMAP> IGEN_SAMPLESCIENTIFICTESTMAP { get; set; }
        public virtual DbSet<IGEN_SCIENTIFICMARKETINGMAP> IGEN_SCIENTIFICMARKETINGMAP { get; set; }
        public virtual DbSet<IGEN_SCIENTIFICRESULT> IGEN_SCIENTIFICRESULT { get; set; }
        public virtual DbSet<IGEN_SCIENTIFICRESULTMARKER> IGEN_SCIENTIFICRESULTMARKER { get; set; }
        public virtual DbSet<IGEN_SCIENTIFICTEST> IGEN_SCIENTIFICTEST { get; set; }
        public virtual DbSet<IGEN_SCIENTIFICTESTMARKERMAP> IGEN_SCIENTIFICTESTMARKERMAP { get; set; }
        public virtual DbSet<IGEN_SCORE> IGEN_SCORE { get; set; }
        public virtual DbSet<IGEN_SEASON> IGEN_SEASON { get; set; }
        public virtual DbSet<IGEN_SIREEXCLUDEDMARKER> IGEN_SIREEXCLUDEDMARKER { get; set; }
        public virtual DbSet<IGEN_SORTFILTER> IGEN_SORTFILTER { get; set; }
        public virtual DbSet<Igen_tempMarketingTestResult> Igen_tempMarketingTestResult { get; set; }
        public virtual DbSet<Igen_tempSample> Igen_tempSample { get; set; }
        public virtual DbSet<Igen_tempSampleSire> Igen_tempSampleSire { get; set; }
        public virtual DbSet<igen_tempSampleStatus> igen_tempSampleStatus { get; set; }
        public virtual DbSet<Igen_TransferProduct> Igen_TransferProduct { get; set; }
        public virtual DbSet<IGEN_USER> IGEN_USER { get; set; }
        public virtual DbSet<TraitMarketingTest> TraitMarketingTests { get; set; }
        public virtual DbSet<C_IgenityTest___dbo___IGEN_CONFLICTCODE_> C_IgenityTest___dbo___IGEN_CONFLICTCODE_ { get; set; }
        public virtual DbSet<IGEN_breed> IGEN_breed { get; set; }
        public virtual DbSet<IGEN_CONFIG> IGEN_CONFIG { get; set; }
        public virtual DbSet<igen_config_dup> igen_config_dup { get; set; }
        public virtual DbSet<IGEN_CONFLICTCODE> IGEN_CONFLICTCODE { get; set; }
        public virtual DbSet<IGEN_CONFLICTCODE_06182018> IGEN_CONFLICTCODE_06182018 { get; set; }
        public virtual DbSet<IGEN_COUNTYREPTABLE> IGEN_COUNTYREPTABLE { get; set; }
        public virtual DbSet<IGEN_CUSTOMERGOALWEIGHT> IGEN_CUSTOMERGOALWEIGHT { get; set; }
        public virtual DbSet<IGEN_CUSTOMERPROGRAM> IGEN_CUSTOMERPROGRAM { get; set; }
        public virtual DbSet<IGEN_CUSTOMINDEXMAPTESTS> IGEN_CUSTOMINDEXMAPTESTS { get; set; }
        public virtual DbSet<IGEN_IMPORTLOG> IGEN_IMPORTLOG { get; set; }
        public virtual DbSet<IGEN_LIMS_Order_ETL_temp_Errors> IGEN_LIMS_Order_ETL_temp_Errors { get; set; }
        public virtual DbSet<IGEN_LIMS_Order_ETL_temp_LineItems> IGEN_LIMS_Order_ETL_temp_LineItems { get; set; }
        public virtual DbSet<IGEN_LIMS_Order_ETL_temp_Orders> IGEN_LIMS_Order_ETL_temp_Orders { get; set; }
        public virtual DbSet<IGEN_LIMS_Order_ETL_temp_Samples> IGEN_LIMS_Order_ETL_temp_Samples { get; set; }
        public virtual DbSet<IGEN_LIMS_Order_ETL_temp_SamplesInLineItems> IGEN_LIMS_Order_ETL_temp_SamplesInLineItems { get; set; }
        public virtual DbSet<igen_login20150917OLD> igen_login20150917OLD { get; set; }
        public virtual DbSet<igen_markeingtestresult_dfp03132018> igen_markeingtestresult_dfp03132018 { get; set; }
        public virtual DbSet<IGEN_MARKETINGINDEXTESTMAP> IGEN_MARKETINGINDEXTESTMAP { get; set; }
        public virtual DbSet<igen_marketingtestresult_96422> igen_marketingtestresult_96422 { get; set; }
        public virtual DbSet<IGEN_MARKETINGTESTRESULT_Delete> IGEN_MARKETINGTESTRESULT_Delete { get; set; }
        public virtual DbSet<IGEN_MARKETINGTESTRESULT_HIST> IGEN_MARKETINGTESTRESULT_HIST { get; set; }
        public virtual DbSet<IGEN_NMBREEDPERCENTILERANGE> IGEN_NMBREEDPERCENTILERANGE { get; set; }
        public virtual DbSet<IGEN_PAYMENTTRANSACTION> IGEN_PAYMENTTRANSACTION { get; set; }
        public virtual DbSet<IGEN_PRODUCTTESTOVERRIDE> IGEN_PRODUCTTESTOVERRIDE { get; set; }
        public virtual DbSet<IGEN_SAMPLEPRODUCTREPORTSTATUS> IGEN_SAMPLEPRODUCTREPORTSTATUS { get; set; }
        public virtual DbSet<Igen_tempMarketingTestResult_delete> Igen_tempMarketingTestResult_delete { get; set; }
        public virtual DbSet<Igen_tempMarketingTestResult_delete_t> Igen_tempMarketingTestResult_delete_t { get; set; }
        public virtual DbSet<igen_TempMarketingTestResult_t> igen_TempMarketingTestResult_t { get; set; }
        public virtual DbSet<Igen_tempSample_3_6m> Igen_tempSample_3_6m { get; set; }
        public virtual DbSet<Igen_tempSample_3m> Igen_tempSample_3m { get; set; }
        public virtual DbSet<Igen_tempSample_6_9m> Igen_tempSample_6_9m { get; set; }
        public virtual DbSet<Igen_tempSample_9_11m> Igen_tempSample_9_11m { get; set; }
        public virtual DbSet<IGEN_VIAL_DETAIL_PART> IGEN_VIAL_DETAIL_PART { get; set; }
        public virtual DbSet<IGEN_ZIPCODECOUNTYCONVERSION> IGEN_ZIPCODECOUNTYCONVERSION { get; set; }
        public virtual DbSet<prod_IGEN_SCIENTIFICRESULT> prod_IGEN_SCIENTIFICRESULT { get; set; }
        public virtual DbSet<QUEST_SL_TEMP_EXPLAIN1> QUEST_SL_TEMP_EXPLAIN1 { get; set; }
        public virtual DbSet<SSIS_DeleteLog> SSIS_DeleteLog { get; set; }
        public virtual DbSet<SSIS_EndDate> SSIS_EndDate { get; set; }
        public virtual DbSet<SSIS_StartDate> SSIS_StartDate { get; set; }
        public virtual DbSet<SSIS_TableColumnTrigger_Log> SSIS_TableColumnTrigger_Log { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C_IgenityTest___dbo___IGEN_CONFLICTCODE_Old_>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<C_IgenityTest___dbo___IGEN_CONFLICTCODE_Old_>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_IgenityTest___dbo___IGEN_CONFLICTCODE_Old_>()
                .Property(e => e.Meaning)
                .IsUnicode(false);

            modelBuilder.Entity<C_IgenityTest___dbo___IGEN_CONFLICTCODE_Old_>()
                .Property(e => e.Correction)
                .IsUnicode(false);

            modelBuilder.Entity<C_IgenityTest___dbo___IGEN_CONFLICTCODE_Old_>()
                .Property(e => e.GeneseekResponse)
                .IsUnicode(false);

            modelBuilder.Entity<C_IgenityTest___dbo___IGEN_CONFLICTCODE_Old_>()
                .Property(e => e.CustomerActionUSBreed)
                .IsUnicode(false);

            modelBuilder.Entity<C_IgenityTest___dbo___IGEN_CONFLICTCODE_Old_>()
                .Property(e => e.CustomerActionNonUSBreed)
                .IsUnicode(false);

            modelBuilder.Entity<C_IgenityTest___dbo___IGEN_CONFLICTCODE_Old_>()
                .Property(e => e.CustomerAction)
                .IsUnicode(false);

            modelBuilder.Entity<C_IgenityTest___dbo___IGEN_CONFLICTCODE_Old_>()
                .HasMany(e => e.IGEN_CONFLICTDETAILS)
                .WithOptional(e => e.C_IgenityTest___dbo___IGEN_CONFLICTCODE_Old_)
                .HasForeignKey(e => e.CodeID);

            modelBuilder.Entity<IGEN_ANIMAL>()
                .Property(e => e.ANIMALID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ANIMAL>()
                .Property(e => e.BREEDASSOCIATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ANIMAL>()
                .Property(e => e.ELECTRONICID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ANIMAL>()
                .Property(e => e.SEX)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ANIMAL>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ANIMAL>()
                .Property(e => e.BREED1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ANIMAL>()
                .Property(e => e.BREED2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ANIMAL>()
                .Property(e => e.SIREGROUP)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ANIMAL>()
                .Property(e => e.BIRTHDATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_ANIMAL>()
                .Property(e => e.ANIMALID2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ANIMAL>()
                .HasMany(e => e.IGEN_ANIMALBREEDASSOCIATION)
                .WithRequired(e => e.IGEN_ANIMAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_ANIMAL>()
                .HasMany(e => e.IGEN_SAMPLE)
                .WithRequired(e => e.IGEN_ANIMAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_ANIMALBREEDASSOCIATION>()
                .Property(e => e.BREEDASSOCIATIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ANIMALBREEDASSOCIATION>()
                .Property(e => e.REGISTRATIONNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ANIMALBREEDASSOCIATION>()
                .Property(e => e.CASENUM)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_breed_old>()
                .Property(e => e.BREED)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_breed_old>()
                .Property(e => e.BREEDASSOCIATIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_breed_old>()
                .Property(e => e.BREED_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_breed_old>()
                .Property(e => e.BREEDASSOC_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_breed_old>()
                .Property(e => e.GACONTACTFIRSTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_breed_old>()
                .Property(e => e.GACONTACTLASTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_breed_old>()
                .Property(e => e.GACONTACTEMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_breed_old>()
                .HasMany(e => e.IGEN_PERCENTILERANGE)
                .WithRequired(e => e.IGEN_breed_old)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_COMPPROVIDER>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_COMPPROVIDER>()
                .HasMany(e => e.IGEN_COMPPROVIDERSCHEDULE)
                .WithRequired(e => e.IGEN_COMPPROVIDER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_COMPPROVIDER>()
                .HasMany(e => e.IGEN_COMPSALESREP)
                .WithRequired(e => e.IGEN_COMPPROVIDER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_COMPSALESREP>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_COMPSALESREP>()
                .Property(e => e.EXTERNALID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_COMPSCHEDULE>()
                .Property(e => e.STARTDATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_COMPSCHEDULE>()
                .Property(e => e.ENDDATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_COMPSCHEDULE>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_COMPSCHEDULE>()
                .Property(e => e.ALGORITHM)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_COMPSCHEDULE>()
                .HasMany(e => e.IGEN_COMPPROVIDERSCHEDULE)
                .WithRequired(e => e.IGEN_COMPSCHEDULE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_COMPSCHEDULE>()
                .HasMany(e => e.IGEN_COMPRATE)
                .WithRequired(e => e.IGEN_COMPSCHEDULE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_CONFIG_old>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFIG_old>()
                .Property(e => e.VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFIG_old>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFLICT>()
                .Property(e => e.ID18)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFLICT>()
                .Property(e => e.BarcodeID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFLICT>()
                .Property(e => e.AnimalName)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFLICT>()
                .HasMany(e => e.IGEN_CONFLICTDETAILS)
                .WithOptional(e => e.IGEN_CONFLICT)
                .HasForeignKey(e => e.ConflictID);

            modelBuilder.Entity<IGEN_CONFLICTDETAILS>()
                .Property(e => e.IDValue)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .Property(e => e.SHIPTO)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .Property(e => e.BILLTO)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .Property(e => e.ACCOUNTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .Property(e => e.CONTACTLASTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .Property(e => e.CONTACTFIRSTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .Property(e => e.ADDRESSLINE1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .Property(e => e.ADDRESSLINE2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .Property(e => e.STATE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .Property(e => e.POSTALCODE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .Property(e => e.COUNTRY)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .Property(e => e.PHONE1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .Property(e => e.PHONE2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .Property(e => e.PHONE3)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .Property(e => e.BREEDASSOCIATIONBREED)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .Property(e => e.BREEDASSOCIATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .Property(e => e.HERDCODE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .Property(e => e.EMAIL1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .Property(e => e.WEBSITE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .HasMany(e => e.IGEN_ANIMAL)
                .WithRequired(e => e.IGEN_CUSTOMER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .HasMany(e => e.IGEN_CUSTOMERBREEDASSOCIATION)
                .WithRequired(e => e.IGEN_CUSTOMER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .HasMany(e => e.IGEN_CUSTOMERGOAL)
                .WithRequired(e => e.IGEN_CUSTOMER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .HasMany(e => e.IGEN_CUSTOMERPROGRAMPERIOD)
                .WithRequired(e => e.IGEN_CUSTOMER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .HasMany(e => e.IGEN_CUSTOMERLOGIN)
                .WithRequired(e => e.IGEN_CUSTOMER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .HasMany(e => e.IGEN_GROUPMEMBER)
                .WithRequired(e => e.IGEN_CUSTOMER)
                .HasForeignKey(e => e.MEMBER_CUST_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .HasMany(e => e.IGEN_IGENITYORDER)
                .WithRequired(e => e.IGEN_CUSTOMER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .HasMany(e => e.IGEN_PENDINGANIMAL)
                .WithRequired(e => e.IGEN_CUSTOMER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_CUSTOMER>()
                .HasMany(e => e.IGEN_PAYMENTTRANSACTION)
                .WithRequired(e => e.IGEN_CUSTOMER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_CUSTOMERBREEDASSOCIATION>()
                .Property(e => e.BREEDASSOCIATIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMERBREEDASSOCIATION>()
                .Property(e => e.MEMBERNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMERGOAL>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMERGOAL>()
                .HasMany(e => e.IGEN_CUSTOMERGOALWEIGHT)
                .WithRequired(e => e.IGEN_CUSTOMERGOAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_CUSTOMERPROGRAMPERIOD>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMERPROGRAMPERIOD>()
                .HasMany(e => e.IGEN_CUSTOMERPROGRAM)
                .WithRequired(e => e.IGEN_CUSTOMERPROGRAMPERIOD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_CUSTOMINDEXMAP>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_DAMEXCLUDEDMARKER>()
                .Property(e => e.EXCLUSION_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ERP>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ERP>()
                .HasMany(e => e.IGEN_CUSTOMER)
                .WithRequired(e => e.IGEN_ERP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_ERP>()
                .HasMany(e => e.IGEN_ERPPRODUCT)
                .WithRequired(e => e.IGEN_ERP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_ERP>()
                .HasMany(e => e.IGEN_PRODUCTTESTOVERRIDE)
                .WithRequired(e => e.IGEN_ERP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_ERPCUSTNUMBER>()
                .Property(e => e.ERPNAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ERPCUSTNUMBER>()
                .Property(e => e.PREFIX)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ERPPRODUCT>()
                .Property(e => e.ERPPRODUCTID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ErrorLog>()
                .Property(e => e.ErrorProcedure)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ErrorLog>()
                .Property(e => e.ErrorMessage)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_EVENTSCALENDAR>()
                .Property(e => e.TITLE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_EVENTSCALENDAR>()
                .Property(e => e.STARTDATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_EVENTSCALENDAR>()
                .Property(e => e.ENDDATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_EVENTSCALENDAR>()
                .Property(e => e.LOCATION)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_EVENTSCALENDAR>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_EVENTSCALENDAR>()
                .Property(e => e.ADMINEMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_EVENTSCALENDAR>()
                .Property(e => e.STATUSDATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_EVENTSCALENDAR>()
                .Property(e => e.REASON)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_EVENTSCALENDAR>()
                .Property(e => e.SUBMITDATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_FIELDVALUES>()
                .Property(e => e.FIELD)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_FIELDVALUES>()
                .Property(e => e.FIELDVALUE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_FIELDVALUES>()
                .Property(e => e.FIELDDEFINITION)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_FIELDVALUES>()
                .Property(e => e.PARENTFIELD)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_FIELDVALUES>()
                .HasMany(e => e.IGEN_ANIMAL)
                .WithOptional(e => e.IGEN_FIELDVALUES)
                .HasForeignKey(e => e.BIRTHSTATUS);

            modelBuilder.Entity<IGEN_FILTER>()
                .Property(e => e.EXPRESSION)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_FILTER>()
                .Property(e => e.VALUE1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_FILTER>()
                .Property(e => e.VALUE2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_FILTER>()
                .Property(e => e.SORTORDER)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ForResultCalculations>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ForResultCalculations>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ForResultCalculations>()
                .Property(e => e.Formulae)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_GROUP>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_GROUP>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_GROUP>()
                .HasMany(e => e.IGEN_GROUPMEMBER)
                .WithRequired(e => e.IGEN_GROUP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_IGENITYORDER>()
                .Property(e => e.CHECKNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_IGENITYORDER>()
                .Property(e => e.ORDERTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_IGENITYORDER>()
                .Property(e => e.MASTERORDERID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_IGENITYORDER>()
                .Property(e => e.PAYMENTTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_IGENITYORDER>()
                .Property(e => e.PAYMENTREFERENCE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_IGENITYORDER>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_IGENITYORDER>()
                .Property(e => e.EMAILRECEIVED_DATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_IGENITYORDER>()
                .HasMany(e => e.IGEN_ORDERINVOICES)
                .WithRequired(e => e.IGEN_IGENITYORDER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_IGENITYORDER>()
                .HasMany(e => e.IGEN_ORDERSTATUS)
                .WithRequired(e => e.IGEN_IGENITYORDER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_IGENITYORDER>()
                .HasMany(e => e.IGEN_SAMPLE)
                .WithRequired(e => e.IGEN_IGENITYORDER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_IMPORTCHECKPOINT>()
                .Property(e => e.AREA)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_IMPORTCHECKPOINT>()
                .Property(e => e.STARTDATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_IMPORTCHECKPOINT>()
                .Property(e => e.ENDDATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_LAB>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LAB>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LAB>()
                .HasMany(e => e.IGEN_CONFLICT)
                .WithRequired(e => e.IGEN_LAB)
                .HasForeignKey(e => e.LabId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_LAB>()
                .HasMany(e => e.IGEN_IGENITYORDER)
                .WithRequired(e => e.IGEN_LAB)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_LAB>()
                .HasMany(e => e.IGEN_LABSCIENTIFICTESTMAP)
                .WithRequired(e => e.IGEN_LAB)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_LIMSGENOMICPRODUCTSCIENTIFICTESTMAP>()
                .HasMany(e => e.IGEN_PRODUCTSUSEDBY)
                .WithOptional(e => e.IGEN_LIMSGENOMICPRODUCTSCIENTIFICTESTMAP)
                .HasForeignKey(e => e.UsedByID);

            modelBuilder.Entity<IGEN_LOCALE>()
                .Property(e => e.LANGUAGE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LOCALE>()
                .Property(e => e.LOCALE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LOCALE>()
                .HasMany(e => e.IGEN_MARKETINGTESTGROUPLOCALE)
                .WithRequired(e => e.IGEN_LOCALE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_LOCALE>()
                .HasMany(e => e.IGEN_MARKETINGTESTLOCALE)
                .WithRequired(e => e.IGEN_LOCALE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_LOCALE>()
                .HasMany(e => e.IGEN_PRODUCTLOCALE)
                .WithRequired(e => e.IGEN_LOCALE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_LOGIN>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LOGIN>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LOGIN>()
                .Property(e => e.QUESTION)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LOGIN>()
                .Property(e => e.ANSWER)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LOGIN>()
                .Property(e => e.FIRSTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LOGIN>()
                .Property(e => e.LASTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LOGIN>()
                .Property(e => e.PHONE1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LOGIN>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LOGIN>()
                .Property(e => e.OPERATIONNAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LOGIN>()
                .Property(e => e.ADDRESS1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LOGIN>()
                .Property(e => e.ADDRESS2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LOGIN>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LOGIN>()
                .Property(e => e.STATE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LOGIN>()
                .Property(e => e.ZIP)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LOGIN>()
                .Property(e => e.SUBMIT_DATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_LOGIN>()
                .Property(e => e.ACTIVEREASON)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LOGIN>()
                .Property(e => e.WEBSITE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LOGIN>()
                .Property(e => e.EXTRADATA)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LOGIN>()
                .HasMany(e => e.IGEN_CUSTOMERLOGIN)
                .WithRequired(e => e.IGEN_LOGIN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_LOGIN>()
                .HasMany(e => e.IGEN_EVENTSCALENDAR)
                .WithRequired(e => e.IGEN_LOGIN)
                .HasForeignKey(e => e.SUBMITTER_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_LOGIN>()
                .HasMany(e => e.IGEN_SORTFILTER)
                .WithRequired(e => e.IGEN_LOGIN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKER>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKER>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKER>()
                .Property(e => e.RESULT1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKER>()
                .Property(e => e.RESULT2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKER>()
                .HasMany(e => e.IGEN_ABMAPPING)
                .WithRequired(e => e.IGEN_MARKER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKER>()
                .HasMany(e => e.IGEN_DAMEXCLUDEDMARKER)
                .WithRequired(e => e.IGEN_MARKER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKER>()
                .HasMany(e => e.IGEN_MARKERMICROSAT)
                .WithRequired(e => e.IGEN_MARKER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKER>()
                .HasMany(e => e.IGEN_MARKERALIAS)
                .WithRequired(e => e.IGEN_MARKER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKER>()
                .HasMany(e => e.IGEN_MARKERPERIODMARKERMAP)
                .WithRequired(e => e.IGEN_MARKER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKER>()
                .HasMany(e => e.IGEN_RESULTEFFECTMARKER)
                .WithRequired(e => e.IGEN_MARKER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKER>()
                .HasMany(e => e.IGEN_RESULTMAPRESULTMARKER)
                .WithRequired(e => e.IGEN_MARKER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKER>()
                .HasMany(e => e.IGEN_SIREEXCLUDEDMARKER)
                .WithRequired(e => e.IGEN_MARKER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKER>()
                .HasMany(e => e.IGEN_SCIENTIFICRESULTMARKER)
                .WithRequired(e => e.IGEN_MARKER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKER>()
                .HasMany(e => e.IGEN_SCIENTIFICTESTMARKERMAP)
                .WithRequired(e => e.IGEN_MARKER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKERALIAS>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKERMICROSAT>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKETINGINDEXPERIOD>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKETINGINDEXPERIOD>()
                .HasMany(e => e.IGEN_MARKETINGINDEXTESTMAP)
                .WithRequired(e => e.IGEN_MARKETINGINDEXPERIOD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKETINGMARKERSPERIOD>()
                .Property(e => e.EFFECTIVESTARTDATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_MARKETINGMARKERSPERIOD>()
                .Property(e => e.EFFECTIVEENDDATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_MARKETINGMARKERSPERIOD>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKETINGMARKERSPERIOD>()
                .HasMany(e => e.IGEN_MARKERPERIODMARKERMAP)
                .WithRequired(e => e.IGEN_MARKETINGMARKERSPERIOD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKETINGMARKERSPERIOD>()
                .HasMany(e => e.IGEN_RESULTMAP)
                .WithRequired(e => e.IGEN_MARKETINGMARKERSPERIOD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKETINGTEST>()
                .Property(e => e.EFFECTUOM)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKETINGTEST>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKETINGTEST>()
                .Property(e => e.ABBREVIATION)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKETINGTEST>()
                .HasMany(e => e.IGEN_FILTER)
                .WithRequired(e => e.IGEN_MARKETINGTEST)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKETINGTEST>()
                .HasMany(e => e.IGEN_MARKETINGINDEXPERIOD)
                .WithRequired(e => e.IGEN_MARKETINGTEST)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKETINGTEST>()
                .HasMany(e => e.IGEN_MARKETINGMARKERSPERIOD)
                .WithRequired(e => e.IGEN_MARKETINGTEST)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKETINGTEST>()
                .HasMany(e => e.IGEN_MarketingTestResultfieldMap)
                .WithRequired(e => e.IGEN_MARKETINGTEST)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKETINGTEST>()
                .HasMany(e => e.Igen_TransferProduct)
                .WithRequired(e => e.IGEN_MARKETINGTEST)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKETINGTEST>()
                .HasMany(e => e.IGEN_MARKETINGTESTRESULTCALCULATION)
                .WithRequired(e => e.IGEN_MARKETINGTEST)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKETINGTEST>()
                .HasMany(e => e.IGEN_CUSTOMERGOALWEIGHT)
                .WithRequired(e => e.IGEN_MARKETINGTEST)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKETINGTEST>()
                .HasMany(e => e.IGEN_MARKETINGINDEXTESTMAP)
                .WithRequired(e => e.IGEN_MARKETINGTEST)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKETINGTEST>()
                .HasMany(e => e.IGEN_MARKETINGTESTGROUPTESTMAP)
                .WithRequired(e => e.IGEN_MARKETINGTEST)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKETINGTEST>()
                .HasMany(e => e.IGEN_MARKETINGTESTLOCALE)
                .WithRequired(e => e.IGEN_MARKETINGTEST)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKETINGTEST>()
                .HasMany(e => e.IGEN_MARKETINGTESTRESULT)
                .WithRequired(e => e.IGEN_MARKETINGTEST)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKETINGTEST>()
                .HasMany(e => e.IGEN_MARKETINGTESTRESULT_HIST)
                .WithRequired(e => e.IGEN_MARKETINGTEST)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKETINGTEST>()
                .HasMany(e => e.IGEN_PRODUCTMARKETINGTESTMAP)
                .WithRequired(e => e.IGEN_MARKETINGTEST)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKETINGTEST>()
                .HasMany(e => e.IGEN_SCIENTIFICMARKETINGMAP)
                .WithRequired(e => e.IGEN_MARKETINGTEST)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKETINGTESTGROUP>()
                .Property(e => e.ABBREVIATION)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKETINGTESTGROUP>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKETINGTESTGROUP>()
                .HasMany(e => e.IGEN_MARKETINGTESTGROUPLOCALE)
                .WithRequired(e => e.IGEN_MARKETINGTESTGROUP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKETINGTESTGROUP>()
                .HasMany(e => e.IGEN_MARKETINGTESTGROUPTESTMAP)
                .WithRequired(e => e.IGEN_MARKETINGTESTGROUP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_MARKETINGTESTGROUPLOCALE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKETINGTESTLOCALE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKETINGTESTRESULT>()
                .Property(e => e.MARKETINGRESULT)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKETINGTESTRESULT>()
                .Property(e => e.GENOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKETINGTESTRESULTCALCULATION>()
                .Property(e => e.BREED)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKETINGTESTRESULTCALCULATION>()
                .Property(e => e.SEX)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MarketingTestResultfieldMap>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ORDERINVOICES>()
                .Property(e => e.INVOICEID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ORDERKIT>()
                .Property(e => e.COLLECTOR_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ORDERKIT>()
                .Property(e => e.OPERATION_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ORDERKIT>()
                .Property(e => e.LASTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ORDERKIT>()
                .Property(e => e.FIRSTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ORDERKIT>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ORDERKIT>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ORDERKIT>()
                .Property(e => e.SUBMITTER_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ORDERKIT>()
                .Property(e => e.SHIP_ADDRESS1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ORDERKIT>()
                .Property(e => e.SHIP_ADDRESS2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ORDERKIT>()
                .Property(e => e.SHIP_CITY)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ORDERKIT>()
                .Property(e => e.SHIP_STATE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ORDERKIT>()
                .Property(e => e.SHIP_POSTALCODE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ORDERKIT>()
                .Property(e => e.SHIP_COUNTRY)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ORDERKIT>()
                .Property(e => e.BILL_ADDRESS1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ORDERKIT>()
                .Property(e => e.BILL_ADDRESS2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ORDERKIT>()
                .Property(e => e.BILL_CITY)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ORDERKIT>()
                .Property(e => e.BILL_STATE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ORDERKIT>()
                .Property(e => e.BILL_POSTALCODE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ORDERKIT>()
                .Property(e => e.BILL_COUNTRY)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ORDERKIT>()
                .Property(e => e.SUBMIT_DATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_ORDERSTATUS>()
                .Property(e => e.STATUSDATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_ORDERSTATUSCODES>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ORDERSTATUSCODES>()
                .HasMany(e => e.IGEN_ORDERSTATUS)
                .WithRequired(e => e.IGEN_ORDERSTATUSCODES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_PARENTMATCHORDER>()
                .Property(e => e.PARENTMATCHORDER_DATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_PARENTMATCHORDER>()
                .Property(e => e.PARENTMATCH_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PARENTMATCHORDER>()
                .Property(e => e.SIRE_BREEDASSOCIATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PARENTMATCHORDER>()
                .Property(e => e.DAM_BREEDASSOCIATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PARENTMATCHORDER>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PARENTMATCHORDERGROUP>()
                .Property(e => e.ORDER_DATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_PARENTMATCHORDERGROUP>()
                .Property(e => e.RESULT_DATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_PARENTMATCHORDERGROUP>()
                .Property(e => e.TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PARENTMATCHORDERGROUP>()
                .Property(e => e.EXPORT_CRITERIA)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PARENTMATCHORDERGROUP>()
                .HasMany(e => e.IGEN_PARENTMATCHORDER)
                .WithRequired(e => e.IGEN_PARENTMATCHORDERGROUP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_PENDINGANIMAL>()
                .Property(e => e.ANIMALID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PENDINGANIMAL>()
                .Property(e => e.ANIMALID2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PENDINGANIMAL>()
                .Property(e => e.SEX)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PENDINGANIMAL>()
                .Property(e => e.BREED1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PENDINGANIMAL>()
                .Property(e => e.BREED2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PENDINGANIMAL>()
                .Property(e => e.BREEDASSOCIATIONCODE1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PENDINGANIMAL>()
                .Property(e => e.REGISTRATIONNUMBER1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PENDINGANIMAL>()
                .Property(e => e.BREEDASSOCIATIONCODE2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PENDINGANIMAL>()
                .Property(e => e.REGISTRATIONNUMBER2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PENDINGANIMAL>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PENDINGANIMAL>()
                .HasMany(e => e.IGEN_PENDINGANIMALNOTIFY)
                .WithRequired(e => e.IGEN_PENDINGANIMAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_PENDINGANIMAL>()
                .HasMany(e => e.IGEN_PENDINGANIMALSTATUS)
                .WithRequired(e => e.IGEN_PENDINGANIMAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_PENDINGANIMALNOTIFY>()
                .Property(e => e.NOTIFY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PENDINGANIMALNOTIFY>()
                .Property(e => e.NOTIFY_EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PENDINGANIMALSTATUS>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PENDINGANIMALSTATUS>()
                .Property(e => e.STATUSDATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_PENDINGANIMALSTATUS>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_POTENTIALDAM>()
                .Property(e => e.BREEDASSOCIATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_POTENTIALDAM>()
                .Property(e => e.BREED1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_POTENTIALDAM>()
                .Property(e => e.BREED2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_POTENTIALDAM>()
                .Property(e => e.CASENUM)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_POTENTIALDAM>()
                .Property(e => e.BARCODEID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_POTENTIALDAM>()
                .Property(e => e.ANIMALID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_POTENTIALDAM>()
                .Property(e => e.ANIMALID2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_POTENTIALDAM>()
                .Property(e => e.PARENTAGEOPTION)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_POTENTIALDAM>()
                .HasMany(e => e.IGEN_DAMEXCLUDEDMARKER)
                .WithRequired(e => e.IGEN_POTENTIALDAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_POTENTIALSIRE>()
                .Property(e => e.BREEDASSOCIATIONID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_POTENTIALSIRE>()
                .Property(e => e.BREED1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_POTENTIALSIRE>()
                .Property(e => e.BREED2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_POTENTIALSIRE>()
                .Property(e => e.CASENUM)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_POTENTIALSIRE>()
                .Property(e => e.BARCODEID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_POTENTIALSIRE>()
                .Property(e => e.ANIMALID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_POTENTIALSIRE>()
                .Property(e => e.ANIMALID2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_POTENTIALSIRE>()
                .Property(e => e.PARENTAGEOPTION)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_POTENTIALSIRE>()
                .HasMany(e => e.IGEN_SIREEXCLUDEDMARKER)
                .WithRequired(e => e.IGEN_POTENTIALSIRE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_PRODUCT>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PRODUCT>()
                .HasMany(e => e.IGEN_ERPPRODUCT)
                .WithRequired(e => e.IGEN_PRODUCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_PRODUCT>()
                .HasMany(e => e.IGEN_MarketingTestResultfieldMap)
                .WithRequired(e => e.IGEN_PRODUCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_PRODUCT>()
                .HasMany(e => e.Igen_TransferProduct)
                .WithRequired(e => e.IGEN_PRODUCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_PRODUCT>()
                .HasMany(e => e.IGEN_PRODUCTLOCALE)
                .WithRequired(e => e.IGEN_PRODUCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_PRODUCT>()
                .HasMany(e => e.IGEN_PRODUCTMARKETINGTESTMAP)
                .WithRequired(e => e.IGEN_PRODUCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_PRODUCT>()
                .HasMany(e => e.IGEN_PRODUCTTESTOVERRIDE)
                .WithRequired(e => e.IGEN_PRODUCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_PRODUCT>()
                .HasMany(e => e.IGEN_SAMPLEPRODUCTMAP)
                .WithRequired(e => e.IGEN_PRODUCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_PRODUCT>()
                .HasMany(e => e.IGEN_SAMPLEPRODUCTREPORTSTATUS)
                .WithRequired(e => e.IGEN_PRODUCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_PRODUCTLOCALE>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PRODUCTLOCALE>()
                .Property(e => e.ABBREVIATION)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PRODUCTSUSEDBY>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PROGRAM>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PROGRAM>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PROSPECT>()
                .Property(e => e.PROSPECT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PROSPECT>()
                .Property(e => e.FIRSTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PROSPECT>()
                .Property(e => e.LASTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PROSPECT>()
                .Property(e => e.OPERATION_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PROSPECT>()
                .Property(e => e.ADDRESSLINE1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PROSPECT>()
                .Property(e => e.ADDRESSLINE2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PROSPECT>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PROSPECT>()
                .Property(e => e.STATE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PROSPECT>()
                .Property(e => e.POSTALCODE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PROSPECT>()
                .Property(e => e.PHONE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PROSPECT>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PROSPECT>()
                .Property(e => e.OPERATION_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PROSPECT>()
                .Property(e => e.OTHER)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PROSPECT>()
                .Property(e => e.BUSINESS_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PROSPECT>()
                .Property(e => e.SUBMIT_DATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_PROSPECT>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_RESULTDIRECTEFFECT>()
                .HasMany(e => e.IGEN_RESULTDIRECTEFFECTSCORE)
                .WithRequired(e => e.IGEN_RESULTDIRECTEFFECT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_RESULTEFFECT>()
                .HasMany(e => e.IGEN_RESULTEFFECTMARKER)
                .WithRequired(e => e.IGEN_RESULTEFFECT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_RESULTEFFECT>()
                .HasMany(e => e.IGEN_RESULTEFFECTSCORE)
                .WithRequired(e => e.IGEN_RESULTEFFECT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_RESULTEFFECTMARKER>()
                .Property(e => e.GENOTYPE1VALUEA1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_RESULTEFFECTMARKER>()
                .Property(e => e.GENOTYPE1VALUEA2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_RESULTEFFECTMARKER>()
                .Property(e => e.GENOTYPE2VALUEA1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_RESULTEFFECTMARKER>()
                .Property(e => e.GENOTYPE2VALUEA2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_RESULTEFFECTMARKER>()
                .Property(e => e.GENOTYPE3VALUEA1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_RESULTEFFECTMARKER>()
                .Property(e => e.GENOTYPE3VALUEA2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_RESULTMAP>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_RESULTMAP>()
                .Property(e => e.EFFECTIVESTARTDATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_RESULTMAP>()
                .Property(e => e.EFFECTIVEENDDATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_RESULTMAP>()
                .Property(e => e.RESULTMAPTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_RESULTMAP>()
                .Property(e => e.SORTTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_RESULTMAP>()
                .Property(e => e.RESULTLOOKUPTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_RESULTMAP>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_RESULTMAP>()
                .HasMany(e => e.IGEN_RESULTMAPRESULT)
                .WithRequired(e => e.IGEN_RESULTMAP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_RESULTMAPRESULT>()
                .Property(e => e.MARKETINGRESULT)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_RESULTMAPRESULT>()
                .Property(e => e.GENOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_RESULTMAPRESULT>()
                .HasMany(e => e.IGEN_RESULTMAPRESULTTEXT)
                .WithRequired(e => e.IGEN_RESULTMAPRESULT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_RESULTMAPRESULT>()
                .HasMany(e => e.IGEN_RESULTMAPRESULTMARKER)
                .WithRequired(e => e.IGEN_RESULTMAPRESULT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_RESULTMAPRESULTMARKER>()
                .Property(e => e.MARKERVALUEA1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_RESULTMAPRESULTMARKER>()
                .Property(e => e.MARKERVALUEA2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_RESULTMAPRESULTTEXT>()
                .Property(e => e.RESULTTEXT)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .Property(e => e.BARCODEID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .Property(e => e.SUBSTRATE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .Property(e => e.CASENUM)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .Property(e => e.REFBARCODEID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .Property(e => e.POSTALCODE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .Property(e => e.ISNEW)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .Property(e => e.ABBI_TEST)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .Property(e => e.SL_ORIGINALSAMPLE_ID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .Property(e => e.LIMS_sMemberCode)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .Property(e => e.LIMS_sBatchID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .Property(e => e.LIMS_sHerdCode)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .Property(e => e.GeneSeekStatus)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .Property(e => e.CustomStatus)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .Property(e => e.LIMS_sSire1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .HasMany(e => e.IGEN_MARKETINGTESTRESULT)
                .WithRequired(e => e.IGEN_SAMPLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .HasMany(e => e.IGEN_POTENTIALDAM)
                .WithRequired(e => e.IGEN_SAMPLE)
                .HasForeignKey(e => e.CALFSAMPLE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .HasMany(e => e.IGEN_POTENTIALDAM1)
                .WithOptional(e => e.IGEN_SAMPLE1)
                .HasForeignKey(e => e.DAMSAMPLE_ID);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .HasMany(e => e.IGEN_POTENTIALSIRE)
                .WithRequired(e => e.IGEN_SAMPLE)
                .HasForeignKey(e => e.CALFSAMPLE_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .HasMany(e => e.IGEN_POTENTIALSIRE1)
                .WithOptional(e => e.IGEN_SAMPLE1)
                .HasForeignKey(e => e.SIRESAMPLE_ID);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .HasMany(e => e.IGEN_MARKETINGTESTRESULT_HIST)
                .WithRequired(e => e.IGEN_SAMPLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .HasMany(e => e.IGEN_SAMPLEPRODUCTMAP)
                .WithRequired(e => e.IGEN_SAMPLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .HasMany(e => e.IGEN_SAMPLEPRODUCTREPORTSTATUS)
                .WithRequired(e => e.IGEN_SAMPLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .HasMany(e => e.IGEN_SAMPLERESULTSMAP)
                .WithRequired(e => e.IGEN_SAMPLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_SAMPLE>()
                .HasMany(e => e.IGEN_SAMPLESCIENTIFICTESTMAP)
                .WithRequired(e => e.IGEN_SAMPLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_SAMPLEEXTENDED>()
                .Property(e => e.KEY)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SAMPLEEXTENDED>()
                .Property(e => e.VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SAMPLELABETA>()
                .Property(e => e.BARCODEID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SAMPLELABETA>()
                .Property(e => e.SUBMIT_DATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_SAMPLELABETA>()
                .Property(e => e.SUBMITTED_BY)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SAMPLELABETA>()
                .Property(e => e.RECEIVED_DATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_SAMPLELABETA>()
                .Property(e => e.ETA_DATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_SAMPLELABETA>()
                .Property(e => e.STAGE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SAMPLELABETA>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SCIENTIFICRESULT>()
                .Property(e => e.DATERECEIVED)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_SCIENTIFICRESULT>()
                .Property(e => e.BARCODEID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SCIENTIFICRESULT>()
                .Property(e => e.REFBARCODEID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SCIENTIFICRESULT>()
                .Property(e => e.RESULTTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SCIENTIFICRESULT>()
                .Property(e => e.RESULT)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SCIENTIFICRESULT>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SCIENTIFICRESULTMARKER>()
                .Property(e => e.MARKERA1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SCIENTIFICRESULTMARKER>()
                .Property(e => e.MARKERA2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SCIENTIFICTEST>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SCIENTIFICTEST>()
                .Property(e => e.ABBREVIATION)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SCIENTIFICTEST>()
                .Property(e => e.ALIAS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SCIENTIFICTEST>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SCIENTIFICTEST>()
                .HasMany(e => e.IGEN_LABSCIENTIFICTESTMAP)
                .WithRequired(e => e.IGEN_SCIENTIFICTEST)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_SCIENTIFICTEST>()
                .HasMany(e => e.IGEN_MARKETINGTESTRESULTCALCULATION)
                .WithRequired(e => e.IGEN_SCIENTIFICTEST)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_SCIENTIFICTEST>()
                .HasMany(e => e.IGEN_SAMPLESCIENTIFICTESTMAP)
                .WithRequired(e => e.IGEN_SCIENTIFICTEST)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_SCIENTIFICTEST>()
                .HasMany(e => e.IGEN_SCIENTIFICMARKETINGMAP)
                .WithRequired(e => e.IGEN_SCIENTIFICTEST)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_SCIENTIFICTEST>()
                .HasMany(e => e.IGEN_PRODUCTTESTOVERRIDE)
                .WithRequired(e => e.IGEN_SCIENTIFICTEST)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_SCIENTIFICTEST>()
                .HasMany(e => e.IGEN_SCIENTIFICTESTMARKERMAP)
                .WithRequired(e => e.IGEN_SCIENTIFICTEST)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_SCORE>()
                .Property(e => e.MARKETINGRESULT)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SCORE>()
                .Property(e => e.RAWVALUE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SCORE>()
                .Property(e => e.RAWVALUEUOM)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SEASON>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SEASON>()
                .Property(e => e.EFFECTIVESTARTDATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_SEASON>()
                .Property(e => e.EFFECTIVEENDDATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_SEASON>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SEASON>()
                .HasMany(e => e.IGEN_CUSTOMERGOAL)
                .WithRequired(e => e.IGEN_SEASON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_SEASON>()
                .HasMany(e => e.IGEN_CUSTOMERPROGRAMPERIOD)
                .WithRequired(e => e.IGEN_SEASON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_SEASON>()
                .HasMany(e => e.IGEN_MARKETINGINDEXPERIOD)
                .WithRequired(e => e.IGEN_SEASON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_SIREEXCLUDEDMARKER>()
                .Property(e => e.EXCLUSION_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SORTFILTER>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SORTFILTER>()
                .HasMany(e => e.IGEN_FILTER)
                .WithRequired(e => e.IGEN_SORTFILTER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Igen_tempMarketingTestResult>()
                .Property(e => e.LIMS_sResult)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempMarketingTestResult>()
                .Property(e => e.LIMS_sBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempSample>()
                .Property(e => e.LIMS_sBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempSample>()
                .Property(e => e.LIMS_sMemberCode)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempSample>()
                .Property(e => e.LIMS_sHerdCode)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempSample>()
                .Property(e => e.LIMS_sBatchID)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempSampleSire>()
                .Property(e => e.LIMS_sBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempSampleSire>()
                .Property(e => e.LIMS_sSire1)
                .IsUnicode(false);

            modelBuilder.Entity<igen_tempSampleStatus>()
                .Property(e => e.LIMS_sbarcode)
                .IsUnicode(false);

            modelBuilder.Entity<igen_tempSampleStatus>()
                .Property(e => e.LIMS_sSTStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_TransferProduct>()
                .Property(e => e.Comments)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_USER>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_USER>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_USER>()
                .Property(e => e.LASTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_USER>()
                .Property(e => e.FIRSTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_USER>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_USER>()
                .Property(e => e.ROLES)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_USER>()
                .HasMany(e => e.IGEN_IGENITYORDER)
                .WithRequired(e => e.IGEN_USER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_USER>()
                .HasMany(e => e.IGEN_PENDINGANIMAL)
                .WithRequired(e => e.IGEN_USER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_USER>()
                .HasMany(e => e.IGEN_SCIENTIFICRESULT)
                .WithRequired(e => e.IGEN_USER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_USER>()
                .HasMany(e => e.IGEN_PAYMENTTRANSACTION)
                .WithRequired(e => e.IGEN_USER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_USER>()
                .HasMany(e => e.IGEN_SAMPLEPRODUCTREPORTSTATUS)
                .WithRequired(e => e.IGEN_USER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TraitMarketingTest>()
                .Property(e => e.TraitName)
                .IsUnicode(false);

            modelBuilder.Entity<C_IgenityTest___dbo___IGEN_CONFLICTCODE_>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<C_IgenityTest___dbo___IGEN_CONFLICTCODE_>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<C_IgenityTest___dbo___IGEN_CONFLICTCODE_>()
                .Property(e => e.Meaning)
                .IsUnicode(false);

            modelBuilder.Entity<C_IgenityTest___dbo___IGEN_CONFLICTCODE_>()
                .Property(e => e.Correction)
                .IsUnicode(false);

            modelBuilder.Entity<C_IgenityTest___dbo___IGEN_CONFLICTCODE_>()
                .Property(e => e.GeneseekResponse)
                .IsUnicode(false);

            modelBuilder.Entity<C_IgenityTest___dbo___IGEN_CONFLICTCODE_>()
                .Property(e => e.CustomerActionUSBreed)
                .IsUnicode(false);

            modelBuilder.Entity<C_IgenityTest___dbo___IGEN_CONFLICTCODE_>()
                .Property(e => e.CustomerActionNonUSBreed)
                .IsUnicode(false);

            modelBuilder.Entity<C_IgenityTest___dbo___IGEN_CONFLICTCODE_>()
                .Property(e => e.CustomerAction)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_breed>()
                .Property(e => e.BREED)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_breed>()
                .Property(e => e.BREEDASSOCIATIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_breed>()
                .Property(e => e.BREED_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_breed>()
                .Property(e => e.BREEDASSOC_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_breed>()
                .Property(e => e.GACONTACTFIRSTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_breed>()
                .Property(e => e.GACONTACTLASTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_breed>()
                .Property(e => e.GACONTACTEMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFIG>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFIG>()
                .Property(e => e.VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFIG>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<igen_config_dup>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<igen_config_dup>()
                .Property(e => e.VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<igen_config_dup>()
                .Property(e => e.DESCRIPTION)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFLICTCODE>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFLICTCODE>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFLICTCODE>()
                .Property(e => e.Meaning)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFLICTCODE>()
                .Property(e => e.Correction)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFLICTCODE>()
                .Property(e => e.GeneseekResponse)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFLICTCODE>()
                .Property(e => e.CustomerActionUSBreed)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFLICTCODE>()
                .Property(e => e.CustomerActionNonUSBreed)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFLICTCODE>()
                .Property(e => e.CustomerAction)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFLICTCODE_06182018>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFLICTCODE_06182018>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFLICTCODE_06182018>()
                .Property(e => e.Meaning)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFLICTCODE_06182018>()
                .Property(e => e.Correction)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFLICTCODE_06182018>()
                .Property(e => e.GeneseekResponse)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFLICTCODE_06182018>()
                .Property(e => e.CustomerActionUSBreed)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFLICTCODE_06182018>()
                .Property(e => e.CustomerActionNonUSBreed)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CONFLICTCODE_06182018>()
                .Property(e => e.CustomerAction)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_COUNTYREPTABLE>()
                .Property(e => e.COUNTYNAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_COUNTYREPTABLE>()
                .Property(e => e.STATE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_COUNTYREPTABLE>()
                .Property(e => e.REP)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMERGOALWEIGHT>()
                .Property(e => e.FILTERTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMERGOALWEIGHT>()
                .Property(e => e.FILTERVALUE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMERGOALWEIGHT>()
                .Property(e => e.SORTBY)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMERGOALWEIGHT>()
                .Property(e => e.MAPTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMERGOALWEIGHT>()
                .Property(e => e.ALIAS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMERPROGRAM>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMINDEXMAPTESTS>()
                .Property(e => e.MAPTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_IMPORTLOG>()
                .Property(e => e.IMPORT_AREA)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_IMPORTLOG>()
                .Property(e => e.KEY_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_IMPORTLOG>()
                .Property(e => e.KEY_VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_IMPORTLOG>()
                .Property(e => e.LOG_MESSAGE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_IMPORTLOG>()
                .Property(e => e.TIMESTAMP)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_IMPORTLOG>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Errors>()
                .Property(e => e.sOrgName)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_LineItems>()
                .Property(e => e.nListPriceLI)
                .HasPrecision(10, 2);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_LineItems>()
                .Property(e => e.nDiscountPercentage)
                .HasPrecision(2, 2);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_LineItems>()
                .Property(e => e.sShowResults)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_LineItems>()
                .Property(e => e.sProductName)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Orders>()
                .Property(e => e.sBillable)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Orders>()
                .Property(e => e.sOrderNotes)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Orders>()
                .Property(e => e.sLabNotes)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Orders>()
                .Property(e => e.sCustomerPO)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Orders>()
                .Property(e => e.nTotalBilledAmount)
                .HasPrecision(10, 0);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Orders>()
                .Property(e => e.sClosed)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Orders>()
                .Property(e => e.sShipToID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Orders>()
                .Property(e => e.sEndCustomer)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Orders>()
                .Property(e => e.sHold)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Orders>()
                .Property(e => e.sSLOrderNumber)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Orders>()
                .Property(e => e.sNeoGenShortName)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Orders>()
                .Property(e => e.sOrgName)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sCustomerSampleID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sBarCode)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sAnimalID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sBarCode2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sBreed)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sEarNotch)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sRegistrationNumber)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sMemberCode)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.cSex)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sDam)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sDamAssocCode)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sSire1)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sSire1AssocCode)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sSire2)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sSire2AssocCode)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sSampleNotes)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sSampleStatus)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sSKU)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sHerdCode)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sBirthStatus)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sElectronicID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.BREEDASSOCIATIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sBatchID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_Samples>()
                .Property(e => e.sSampleType)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_SamplesInLineItems>()
                .Property(e => e.sBatchID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_SamplesInLineItems>()
                .Property(e => e.sCustomerTestID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_SamplesInLineItems>()
                .Property(e => e.sRemark)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_SamplesInLineItems>()
                .Property(e => e.sSTStatus)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_SamplesInLineItems>()
                .Property(e => e.sResult)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LIMS_Order_ETL_temp_SamplesInLineItems>()
                .Property(e => e.sSKU)
                .IsUnicode(false);

            modelBuilder.Entity<igen_login20150917OLD>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<igen_login20150917OLD>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<igen_login20150917OLD>()
                .Property(e => e.QUESTION)
                .IsUnicode(false);

            modelBuilder.Entity<igen_login20150917OLD>()
                .Property(e => e.ANSWER)
                .IsUnicode(false);

            modelBuilder.Entity<igen_login20150917OLD>()
                .Property(e => e.FIRSTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<igen_login20150917OLD>()
                .Property(e => e.LASTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<igen_login20150917OLD>()
                .Property(e => e.PHONE1)
                .IsUnicode(false);

            modelBuilder.Entity<igen_login20150917OLD>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<igen_login20150917OLD>()
                .Property(e => e.OPERATIONNAME)
                .IsUnicode(false);

            modelBuilder.Entity<igen_login20150917OLD>()
                .Property(e => e.ADDRESS1)
                .IsUnicode(false);

            modelBuilder.Entity<igen_login20150917OLD>()
                .Property(e => e.ADDRESS2)
                .IsUnicode(false);

            modelBuilder.Entity<igen_login20150917OLD>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<igen_login20150917OLD>()
                .Property(e => e.STATE)
                .IsUnicode(false);

            modelBuilder.Entity<igen_login20150917OLD>()
                .Property(e => e.ZIP)
                .IsUnicode(false);

            modelBuilder.Entity<igen_login20150917OLD>()
                .Property(e => e.SUBMIT_DATE)
                .HasPrecision(0);

            modelBuilder.Entity<igen_login20150917OLD>()
                .Property(e => e.ACTIVEREASON)
                .IsUnicode(false);

            modelBuilder.Entity<igen_login20150917OLD>()
                .Property(e => e.WEBSITE)
                .IsUnicode(false);

            modelBuilder.Entity<igen_login20150917OLD>()
                .Property(e => e.EXTRADATA)
                .IsUnicode(false);

            modelBuilder.Entity<igen_markeingtestresult_dfp03132018>()
                .Property(e => e.MARKETINGRESULT)
                .IsUnicode(false);

            modelBuilder.Entity<igen_markeingtestresult_dfp03132018>()
                .Property(e => e.GENOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKETINGINDEXTESTMAP>()
                .Property(e => e.MAPTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKETINGINDEXTESTMAP>()
                .Property(e => e.ALIAS)
                .IsUnicode(false);

            modelBuilder.Entity<igen_marketingtestresult_96422>()
                .Property(e => e.MARKETINGRESULT)
                .IsUnicode(false);

            modelBuilder.Entity<igen_marketingtestresult_96422>()
                .Property(e => e.GENOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKETINGTESTRESULT_Delete>()
                .Property(e => e.MARKETINGRESULT)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKETINGTESTRESULT_Delete>()
                .Property(e => e.GENOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKETINGTESTRESULT_HIST>()
                .Property(e => e.MARKETINGRESULT)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKETINGTESTRESULT_HIST>()
                .Property(e => e.GENOTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_MARKETINGTESTRESULT_HIST>()
                .Property(e => e.UPDATEDATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_NMBREEDPERCENTILERANGE>()
                .Property(e => e.BREED)
                .IsFixedLength();

            modelBuilder.Entity<IGEN_NMBREEDPERCENTILERANGE>()
                .Property(e => e.SEX)
                .IsFixedLength();

            modelBuilder.Entity<IGEN_PAYMENTTRANSACTION>()
                .Property(e => e.PAYMENT_REF)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PAYMENTTRANSACTION>()
                .Property(e => e.TRAX_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PAYMENTTRANSACTION>()
                .Property(e => e.TRAX_DATE)
                .HasPrecision(0);

            modelBuilder.Entity<IGEN_PAYMENTTRANSACTION>()
                .Property(e => e.TRAX_REFERENCE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PAYMENTTRANSACTION>()
                .Property(e => e.TRAX_COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_SAMPLEPRODUCTREPORTSTATUS>()
                .Property(e => e.REPORTED_DATE)
                .HasPrecision(0);

            modelBuilder.Entity<Igen_tempMarketingTestResult_delete>()
                .Property(e => e.LIMS_sResult)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempMarketingTestResult_delete>()
                .Property(e => e.LIMS_sBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempMarketingTestResult_delete_t>()
                .Property(e => e.LIMS_sResult)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempMarketingTestResult_delete_t>()
                .Property(e => e.LIMS_sBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<igen_TempMarketingTestResult_t>()
                .Property(e => e.LIMS_sResult)
                .IsUnicode(false);

            modelBuilder.Entity<igen_TempMarketingTestResult_t>()
                .Property(e => e.LIMS_sBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempSample_3_6m>()
                .Property(e => e.LIMS_sBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempSample_3_6m>()
                .Property(e => e.LIMS_sMemberCode)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempSample_3_6m>()
                .Property(e => e.LIMS_sHerdCode)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempSample_3_6m>()
                .Property(e => e.LIMS_sBatchID)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempSample_3m>()
                .Property(e => e.LIMS_sBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempSample_3m>()
                .Property(e => e.LIMS_sMemberCode)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempSample_3m>()
                .Property(e => e.LIMS_sHerdCode)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempSample_3m>()
                .Property(e => e.LIMS_sBatchID)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempSample_6_9m>()
                .Property(e => e.LIMS_sBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempSample_6_9m>()
                .Property(e => e.LIMS_sMemberCode)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempSample_6_9m>()
                .Property(e => e.LIMS_sHerdCode)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempSample_6_9m>()
                .Property(e => e.LIMS_sBatchID)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempSample_9_11m>()
                .Property(e => e.LIMS_sBarcode)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempSample_9_11m>()
                .Property(e => e.LIMS_sMemberCode)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempSample_9_11m>()
                .Property(e => e.LIMS_sHerdCode)
                .IsUnicode(false);

            modelBuilder.Entity<Igen_tempSample_9_11m>()
                .Property(e => e.LIMS_sBatchID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_VIAL_DETAIL_PART>()
                .Property(e => e.SAMPLEID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_VIAL_DETAIL_PART>()
                .Property(e => e.CUSTNMBR)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_VIAL_DETAIL_PART>()
                .Property(e => e.ANIMALID)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ZIPCODECOUNTYCONVERSION>()
                .Property(e => e.ZIPCODE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ZIPCODECOUNTYCONVERSION>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ZIPCODECOUNTYCONVERSION>()
                .Property(e => e.STATE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ZIPCODECOUNTYCONVERSION>()
                .Property(e => e.COUNTY)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ZIPCODECOUNTYCONVERSION>()
                .Property(e => e.AREACODE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ZIPCODECOUNTYCONVERSION>()
                .Property(e => e.CITYTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ZIPCODECOUNTYCONVERSION>()
                .Property(e => e.CITYALIASABBREV)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ZIPCODECOUNTYCONVERSION>()
                .Property(e => e.CITYALIASNAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ZIPCODECOUNTYCONVERSION>()
                .Property(e => e.TIMEZONE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ZIPCODECOUNTYCONVERSION>()
                .Property(e => e.COUNTYFIPS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ZIPCODECOUNTYCONVERSION>()
                .Property(e => e.DAYLIGHTSAVINGS)
                .IsUnicode(false);

            modelBuilder.Entity<prod_IGEN_SCIENTIFICRESULT>()
                .Property(e => e.DATERECEIVED)
                .HasPrecision(0);

            modelBuilder.Entity<prod_IGEN_SCIENTIFICRESULT>()
                .Property(e => e.BARCODEID)
                .IsUnicode(false);

            modelBuilder.Entity<prod_IGEN_SCIENTIFICRESULT>()
                .Property(e => e.REFBARCODEID)
                .IsUnicode(false);

            modelBuilder.Entity<prod_IGEN_SCIENTIFICRESULT>()
                .Property(e => e.RESULTTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<prod_IGEN_SCIENTIFICRESULT>()
                .Property(e => e.RESULT)
                .IsUnicode(false);

            modelBuilder.Entity<prod_IGEN_SCIENTIFICRESULT>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<QUEST_SL_TEMP_EXPLAIN1>()
                .Property(e => e.STATEMENT_ID)
                .IsUnicode(false);

            modelBuilder.Entity<QUEST_SL_TEMP_EXPLAIN1>()
                .Property(e => e.TIMESTAMP)
                .HasPrecision(0);

            modelBuilder.Entity<QUEST_SL_TEMP_EXPLAIN1>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<QUEST_SL_TEMP_EXPLAIN1>()
                .Property(e => e.OPERATION)
                .IsUnicode(false);

            modelBuilder.Entity<QUEST_SL_TEMP_EXPLAIN1>()
                .Property(e => e.OPTIONS)
                .IsUnicode(false);

            modelBuilder.Entity<QUEST_SL_TEMP_EXPLAIN1>()
                .Property(e => e.OBJECT_NODE)
                .IsUnicode(false);

            modelBuilder.Entity<QUEST_SL_TEMP_EXPLAIN1>()
                .Property(e => e.OBJECT_OWNER)
                .IsUnicode(false);

            modelBuilder.Entity<QUEST_SL_TEMP_EXPLAIN1>()
                .Property(e => e.OBJECT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<QUEST_SL_TEMP_EXPLAIN1>()
                .Property(e => e.OBJECT_ALIAS)
                .IsUnicode(false);

            modelBuilder.Entity<QUEST_SL_TEMP_EXPLAIN1>()
                .Property(e => e.OBJECT_TYPE)
                .IsUnicode(false);

            modelBuilder.Entity<QUEST_SL_TEMP_EXPLAIN1>()
                .Property(e => e.OPTIMIZER)
                .IsUnicode(false);

            modelBuilder.Entity<QUEST_SL_TEMP_EXPLAIN1>()
                .Property(e => e.OTHER_TAG)
                .IsUnicode(false);

            modelBuilder.Entity<QUEST_SL_TEMP_EXPLAIN1>()
                .Property(e => e.PARTITION_START)
                .IsUnicode(false);

            modelBuilder.Entity<QUEST_SL_TEMP_EXPLAIN1>()
                .Property(e => e.PARTITION_STOP)
                .IsUnicode(false);

            modelBuilder.Entity<QUEST_SL_TEMP_EXPLAIN1>()
                .Property(e => e.OTHER)
                .IsUnicode(false);

            modelBuilder.Entity<QUEST_SL_TEMP_EXPLAIN1>()
                .Property(e => e.DISTRIBUTION)
                .IsUnicode(false);

            modelBuilder.Entity<QUEST_SL_TEMP_EXPLAIN1>()
                .Property(e => e.ACCESS_PREDICATES)
                .IsUnicode(false);

            modelBuilder.Entity<QUEST_SL_TEMP_EXPLAIN1>()
                .Property(e => e.FILTER_PREDICATES)
                .IsUnicode(false);

            modelBuilder.Entity<SSIS_TableColumnTrigger_Log>()
                .Property(e => e.Description)
                .IsUnicode(false);
        }
    }
}
