using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CustomerOrderService;
using System.Runtime.Remoting.Messaging;

namespace CustomerOrderService.Test
{
    [TestFixture(CustomerType.Basic)]
    [TestFixture(CustomerType.Premium,100)]
    public class CustOrderTest
    {
        CustomerType ctype;
        Order o = new Order();
        public CustOrderTest(CustomerType ctype)
        {
            this.ctype = ctype;

        }
        public CustOrderTest(CustomerType ctype,int amount) : this(ctype)
        {
           // this.ctype = ctype;
            o.Amount = amount;
        }
        
        [TestCase]
        public void TestMethod()
        {
            //Assert.IsTrue(ctype == CustomerType.Basic);
            //Assert.IsTrue((ctype == CustomerType.Basic) && (o.Amount==0));
            //Assert.IsTrue((ctype == CustomerType.Premium) && (o.Amount ==100));
            Assert.IsTrue((ctype == CustomerType.Premium) && (o.Amount >= 0));

        }
        [TestCase]
        public void When_Premium_10Percent()
        {
            Customer Cust = new Customer
            {
                CustomerId = "SHA",
                CustName = "Salini",
                CustType = CustomerType.Premium
            };

            Order order = new Order
            {
                OrderId = 1,
                ProdId = 212,
                Quantity = 1,
                Amount = 150
            };
            CustomerOrder cust = new CustomerOrder();
            cust.Discount(Cust, order);  

            Assert.AreEqual(order.Amount,135);
          
        }
        [TestCase]
        public void When_Gold_20Percent()
        {
            Customer Cust = new Customer
            {
                CustomerId = "SHA",
                CustName = "Salini",
                CustType = CustomerType.Gold
            };

            Order order = new Order
            {
                OrderId = 1,
                ProdId = 212,
                Quantity = 1,
                Amount = 150
            };
            CustomerOrder cust = new CustomerOrder();
            cust.Discount(Cust, order);

            Assert.AreEqual(order.Amount, 120);
        }

        [TestCase]
       public void FetchList()
        {
            CustomerOrder customerOrder= new CustomerOrder();
            Customer c1 = new Customer();
            customerOrder.GetCustList(c1);
            List<Customer> clist = new List<Customer>();
            

            clist.Add(new Customer { CustomerId = "ABCD", CustName = "Alex" });
            clist.Add(new Customer { CustomerId = "KHEK", CustName = "Adam" });
            clist.Add(new Customer { CustomerId = "kjhs", CustName = "Ashik" });

            Assert.AreEqual(clist, c1.CustList);
        }
    }
}
