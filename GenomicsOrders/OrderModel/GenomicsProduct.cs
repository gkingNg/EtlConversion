using System.Collections.Generic;

namespace GenomicsOrders.OrderModel
{
    public class GenomicsProduct
    {
        public GenomicsProduct()
        {
            Samples = new List<GenomicsSamples>();
        }

        public int GenomicsProductId { get; set; }

        public List<GenomicsSamples> Samples { get; set; }
    }
}