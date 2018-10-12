using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;

namespace GenomicsData
{
    public abstract class GenericRepository<C, T> :
        IGenericRepository<T> where T : class where C : DbContext, new()
    {

        private C _entities;
        public C Context
        {

            get { return _entities; }
            set { _entities = value; }
        }
        public virtual IQueryable<T> GetAll()
        {

            IQueryable<T> query = _entities.Set<T>();
            return query;
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            IQueryable<T> query = _entities.Set<T>().Where(predicate);
            return query;
        }

        public virtual void Add(T entity)
        {
            _entities.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity)
        {
            _entities.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }


        public virtual void AttachExisting(T entity)
        {
           
            _entities.Set<T>().Attach(entity);
            _entities.Entry(entity).State = EntityState.Modified;

        }
        public virtual void Save()
        {
            try
            {
                _entities.SaveChanges();
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
}