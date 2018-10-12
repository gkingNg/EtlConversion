namespace GenomicsData.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GenomicsModel : DbContext
    {
        public GenomicsModel()
            : base("name=GenomicsModel")
        {
        }

        public virtual DbSet<IGEN_ANIMAL> IGEN_ANIMAL { get; set; }
        public virtual DbSet<IGEN_ANIMALBREEDASSOCIATION> IGEN_ANIMALBREEDASSOCIATION { get; set; }
        public virtual DbSet<IGEN_CUSTOMER> IGEN_CUSTOMER { get; set; }
        public virtual DbSet<IGEN_CUSTOMERBREEDASSOCIATION> IGEN_CUSTOMERBREEDASSOCIATION { get; set; }
        public virtual DbSet<IGEN_ERPPRODUCT> IGEN_ERPPRODUCT { get; set; }
        public virtual DbSet<IGEN_FIELDVALUES> IGEN_FIELDVALUES { get; set; }
        public virtual DbSet<IGEN_IGENITYORDER> IGEN_IGENITYORDER { get; set; }
        public virtual DbSet<IGEN_ORDERSTATUS> IGEN_ORDERSTATUS { get; set; }
        public virtual DbSet<IGEN_ORDERSTATUSCODES> IGEN_ORDERSTATUSCODES { get; set; }
        public virtual DbSet<IGEN_POTENTIALDAM> IGEN_POTENTIALDAM { get; set; }
        public virtual DbSet<IGEN_POTENTIALSIRE> IGEN_POTENTIALSIRE { get; set; }
        public virtual DbSet<IGEN_PRODUCT> IGEN_PRODUCT { get; set; }
        public virtual DbSet<IGEN_SAMPLE> IGEN_SAMPLE { get; set; }
        public virtual DbSet<IGEN_SAMPLEPRODUCTMAP> IGEN_SAMPLEPRODUCTMAP { get; set; }
        public virtual DbSet<IGEN_SCIENTIFICTEST> IGEN_SCIENTIFICTEST { get; set; }
        public virtual DbSet<IGEN_USER> IGEN_USER { get; set; }
        public virtual DbSet<IGEN_LAB> IGEN_LAB { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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
                .HasMany(e => e.IGEN_CUSTOMERBREEDASSOCIATION)
                .WithRequired(e => e.IGEN_CUSTOMER)
                .WillCascadeOnDelete(false);

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
                .HasMany(e => e.IGEN_IGENITYORDER)
                .WithRequired(e => e.IGEN_CUSTOMER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_CUSTOMERBREEDASSOCIATION>()
                .Property(e => e.BREEDASSOCIATIONCODE)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_CUSTOMERBREEDASSOCIATION>()
                .Property(e => e.MEMBERNUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_ERPPRODUCT>()
                .Property(e => e.ERPPRODUCTID)
                .IsUnicode(false);

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
                .HasMany(e => e.IGEN_ORDERSTATUS)
                .WithRequired(e => e.IGEN_IGENITYORDER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_IGENITYORDER>()
                .HasMany(e => e.IGEN_SAMPLE)
                .WithRequired(e => e.IGEN_IGENITYORDER)
                .WillCascadeOnDelete(false);

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

            modelBuilder.Entity<IGEN_PRODUCT>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_PRODUCT>()
                .HasMany(e => e.IGEN_ERPPRODUCT)
                .WithRequired(e => e.IGEN_PRODUCT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IGEN_PRODUCT>()
                .HasMany(e => e.IGEN_SAMPLEPRODUCTMAP)
                .WithRequired(e => e.IGEN_PRODUCT)
                .WillCascadeOnDelete(false);

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
                .HasMany(e => e.IGEN_SAMPLEPRODUCTMAP)
                .WithRequired(e => e.IGEN_SAMPLE)
                .WillCascadeOnDelete(false);

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

            modelBuilder.Entity<IGEN_LAB>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<IGEN_LAB>()
                .Property(e => e.COMMENTS)
                .IsUnicode(false);


            modelBuilder.Entity<IGEN_LAB>()
                .HasMany(e => e.IGEN_IGENITYORDER)
                .WithRequired(e => e.IGEN_LAB)
                .WillCascadeOnDelete(false);

        }
    }
}
