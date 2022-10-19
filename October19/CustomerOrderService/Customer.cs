using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService
{
    public enum CustomerType
    {
        Basic,
        Premium,
        Gold
    }
    public class Customer
    {
        public string CustomerId { get; set; }
        public string CustName { get; set; }
        public CustomerType CustType { get; set; }

        public List<Customer> CustList { get; set; }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public int ProdId { get; set; }
        public int Quantity { get; set; }
        public int Amount{ get; set; }
    }
}
