using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService.Test
{
    [TestFixture]
    public class Test1
    {
        int s;
        [SetUp]
        public void Add()  //compulsory/first in the sequenec
        {
            int x = 10;
            int y = 20;
            s = x + y;
            Console.WriteLine(s);
        }
        [Test]
        public void Subtract()
        {
            int p = s - 10;
            Console.WriteLine(p);
            Assert.AreEqual(p, 20);
        }
        [Test]
        [TearDown]   //Last in the sequence of execution
        public void Multiply()
        {
            int x = 100;
            int y = 20;
            int result = x * y;
            Console.WriteLine(result);
            Assert.AreEqual(result, 2000);
        }

} 
}
