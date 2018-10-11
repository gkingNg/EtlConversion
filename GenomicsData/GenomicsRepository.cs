

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using GenomicsData.Models;

namespace GenomicsData
{
    public class GenomicsRepository
    {
        public DbContext CurrentContext { get; }

        public GenomicsRepository()
        {
            CurrentContext = new GenomicsModel();
            
        }

        public GenomicsRepository(DbContext currentContext)
        {
            CurrentContext = currentContext;

        }

        public int SaveChanges()
        {
            int result = 0;
            try
            {
                result = CurrentContext.SaveChanges();
            }
            catch (DbEntityValidationException ex) //Catch this specific exception
            {

                foreach (var valicationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in valicationErrors.ValidationErrors)
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

            return result;
        }

        public IQueryable<T> GetAll<T>() where T : class
        {

            IQueryable<T> query = CurrentContext.Set<T>();
            return query;
        }


        public IList<IGEN_CUSTOMER> Customer { get; set; }

        public IQueryable<IGEN_ORDERSTATUSCODES> OrderStatusCodes { get; set; }

        public IQueryable<IGEN_ORDERSTATUS> OrderStatus { get; set; }
        public IQueryable<IGEN_FIELDVALUES> FieldStatus { get; set; }
        public IQueryable<IGEN_SAMPLE> Sample { get; set; }
    }
}