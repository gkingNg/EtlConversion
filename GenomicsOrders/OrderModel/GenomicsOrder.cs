using System;
using System.Collections.Generic;
using GenomicsOrders.Utils;

namespace GenomicsOrders.OrderModel
{
    public class GenomicsOrder
    {
        public GenomicsOrder()
        {
            Products = new List<GenomicsProduct>();
        }

        public string Notes { get; set; }
        public int CustId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public OrderOrigin OrderOrigin { get; set; }
        public List<GenomicsProduct> Products { get; set; }
    }
}