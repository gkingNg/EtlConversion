using System;
using System.Data.Entity.Validation;
using System.Diagnostics;
using GenomicsData.Model;

namespace GenomicsData.Repositories
{
    public class AllRepositories
    {
        private readonly GenomicsModel _uow;

        public AllRepositories()
        {
            _uow = new GenomicsModel();
            AnimalRepository = new AnimalRepository(_uow);
            AnimalBreedAssociationRepository = new AnimalBreedAssociationRepository(_uow);
            OrderStatusRepository = new OrderStatusRepository(_uow);
            CustomRepository = new CustomRepository(_uow);
            ErpProductRepository = new ErpProductRepository(_uow);
            FieldValuesRepository = new FieldValuesRepository(_uow);
            IgenitiyOrderRepository = new IgenitiyOrderRepository(_uow);
            OrderStatusCodesRepository = new OrderStatusCodesRepository(_uow);
            DamRepository = new DamRepository(_uow);
            SireRepository = new SireRepository(_uow);
            ProductRepository = new ProductRepository(_uow);
            SampleRepository = new SampleRepository(_uow);
            ScientificTestRepository = new ScientificTestRepository(_uow);
            SampleProductMapRepository = new SampleProductMapRepository(_uow);
            CustomerBreedAssociationRepository = new CustomerBreedAssociationRepository(_uow);
            UserRepository = new UserRepository(_uow);
            LabRepository = new LabRepository(_uow);
        }

        public AnimalRepository AnimalRepository { get; set; }
        public AnimalBreedAssociationRepository AnimalBreedAssociationRepository { get; set; }
        public OrderStatusRepository OrderStatusRepository { get; set; }
        public CustomRepository CustomRepository { get; set; }
        public ErpProductRepository ErpProductRepository { get; set; }
        public FieldValuesRepository FieldValuesRepository { get; set; }
        public IgenitiyOrderRepository IgenitiyOrderRepository { get; set; }
        public OrderStatusCodesRepository OrderStatusCodesRepository { get; set; }
        public DamRepository DamRepository { get; set; }
        public SireRepository SireRepository { get; set; }
        public ProductRepository ProductRepository { get; set; }
        public SampleRepository SampleRepository { get; set; }
        public ScientificTestRepository ScientificTestRepository { get; set; }
        public SampleProductMapRepository SampleProductMapRepository { get; set; }
        public UserRepository UserRepository { get; set; }
        public LabRepository LabRepository { get; set; }

        public CustomerBreedAssociationRepository CustomerBreedAssociationRepository { get; set; }

        public virtual void Save()
        {
            try
            {
                _uow.SaveChanges();
            }
            catch (DbEntityValidationException ex) //Catch this specific exception
            {

                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceError("Entity Validation Error. Property: {0} Error: {1}", validationError.PropertyName,
                            validationError.ErrorMessage);
                    }
                }
                throw;
            }
            catch (Exception exception) //This will catch all other exceptions that occur
            {
                Trace.TraceError("Commit Exception: " + exception.InnerException);
                throw;
            }


        }
    }

    public class AnimalRepository : GenericRepository<GenomicsModel, IGEN_ANIMAL>
    {
        public AnimalRepository(GenomicsModel uow)
        {
            Context = uow;
        }
    }

    public class AnimalBreedAssociationRepository : GenericRepository<GenomicsModel, IGEN_ANIMALBREEDASSOCIATION>
    {
        public AnimalBreedAssociationRepository(GenomicsModel uow)
        {
            Context = uow;
        }
    }

    public class OrderStatusRepository : GenericRepository<GenomicsModel, IGEN_ORDERSTATUS>
    {
        public OrderStatusRepository(GenomicsModel uow)
        {
            Context = uow;
        }
    }

    public class CustomRepository : GenericRepository<GenomicsModel, IGEN_CUSTOMER>
    {
        public CustomRepository(GenomicsModel uow)
        {
            Context = uow;
        }
    }

    public class ErpProductRepository : GenericRepository<GenomicsModel, IGEN_ERPPRODUCT>
    {
        public ErpProductRepository(GenomicsModel uow)
        {
            Context = uow;
        }
    }

    public class FieldValuesRepository : GenericRepository<GenomicsModel, IGEN_FIELDVALUES>
    {
        public FieldValuesRepository(GenomicsModel uow)
        {
            Context = uow;
        }
    }

    public class IgenitiyOrderRepository : GenericRepository<GenomicsModel, IGEN_IGENITYORDER>
    {
        public IgenitiyOrderRepository(GenomicsModel uow)
        {
            Context = uow;
        }
    }

    public class OrderStatusCodesRepository : GenericRepository<GenomicsModel, IGEN_ORDERSTATUSCODES>
    {
        public OrderStatusCodesRepository(GenomicsModel uow)
        {
            Context = uow;
        }
    }

    public class DamRepository : GenericRepository<GenomicsModel, IGEN_POTENTIALDAM>
    {
        public DamRepository(GenomicsModel uow)
        {
            Context = uow;
        }
    }

    public class SireRepository : GenericRepository<GenomicsModel, IGEN_POTENTIALSIRE>
    {
        public SireRepository(GenomicsModel uow)
        {
            Context = uow;
        }
    }

    public class ProductRepository : GenericRepository<GenomicsModel, IGEN_PRODUCT>
    {
        public ProductRepository(GenomicsModel uow)
        {
            Context = uow;
        }
    }

    public class SampleRepository : GenericRepository<GenomicsModel, IGEN_SAMPLE>
    {
        public SampleRepository(GenomicsModel uow)
        {
            Context = uow;
        }
    }

    public class ScientificTestRepository : GenericRepository<GenomicsModel, IGEN_SCIENTIFICTEST>
    {
        public ScientificTestRepository(GenomicsModel uow)
        {
            Context = uow;
        }
    }

    public class SampleProductMapRepository : GenericRepository<GenomicsModel, IGEN_SAMPLEPRODUCTMAP>
    {
        public SampleProductMapRepository(GenomicsModel uow)
        {
            Context = uow;
        }
    }

    public class CustomerBreedAssociationRepository : GenericRepository<GenomicsModel, IGEN_CUSTOMERBREEDASSOCIATION>
    {
        public CustomerBreedAssociationRepository(GenomicsModel uow)
        {
            Context = uow;
        }
    }

    public class UserRepository : GenericRepository<GenomicsModel, IGEN_USER>
    {
        public UserRepository(GenomicsModel uow)
        {
            Context = uow;
        }
    }

    public class LabRepository : GenericRepository<GenomicsModel, IGEN_LAB>
    {
        public LabRepository(GenomicsModel uow)
        {
            Context = uow;
        }
    }
		
}