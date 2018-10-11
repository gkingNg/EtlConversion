using System.Collections.Generic;

namespace GenomicsOrders
{
    public class GenomicsProducts
    {
        public GenomicsProducts()
        {
            Samples = new List<GenomicsSamples>();
        }

        public int GenomicsProductId { get; set; }

        public IList<GenomicsSamples> Samples { get; set; }
    }
}