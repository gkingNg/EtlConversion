

using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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


        public IList<IGEN_CUSTOMER> Customer { get; set; }

        public IQueryable<IGEN_ORDERSTATUSCODES> OrderStatusCodes { get; set; }

        public IQueryable<IGEN_ORDERSTATUS> OrderStatus { get; set; }
        public IQueryable<IGEN_FIELDVALUES> FieldStatus { get; set; }
        public IQueryable<IGEN_SAMPLE> Sample { get; set; }
    }
}