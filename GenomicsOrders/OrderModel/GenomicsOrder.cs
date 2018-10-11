using GenomicsOrders.Utils;
using System;
using System.Collections.Generic;

namespace GenomicsOrders
{
    public class GenomicsOrder
    {
        public GenomicsOrder()
        {
            Products = new List<GenomicsProducts>();
        }

        public string Notes { get; set; }
        public int CustId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }

        public OrderOrigin OrderOrigin { get; set; }


        public IList<GenomicsProducts> Products { get; set; }
    }
}