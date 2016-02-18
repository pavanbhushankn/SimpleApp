using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeApplication1Test
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestMethod1()
        {
            Assert.AreEqual("a", new MyClass().GetValue());
        }
    }

    class MyClass
    {
        public string GetValue() {
            return "a";
        }

    }

   
}
