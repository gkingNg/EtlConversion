

using System.Data.Entity;
using System.Linq;
using GenomicsData.Models;

namespace GenomicsData
{
    public class GenomicsRepository
    {
        public DbContext Context { get; }

        public GenomicsRepository()
        {
            Context = new GenomicsModel();
        }

        public GenomicsRepository(DbContext context)
        {
            Context = context;
        }


        public IQueryable<IGEN_CUSTOMER> Customer { get; set; }

        public IQueryable<IGEN_ORDERSTATUSCODES> OrderStatusCodes { get; set; }

        public IQueryable<IGEN_ORDERSTATUS> OrderStatus { get; set; }
    }
}