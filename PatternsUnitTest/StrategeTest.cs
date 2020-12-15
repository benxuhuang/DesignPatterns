using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stratege;

namespace PatternsUnitTest
{
    [TestClass]
    public class StrategeTest
    {
        [TestMethod]
        public void NormalTest()
        {
            CashContext cc;
            double totalPrice = 0d;
            cc = new CashContext("normal");
            totalPrice = cc.GetResult(700);
            Assert.AreEqual(700,totalPrice);
        }

        [TestMethod]
        public void cashRetuenTest()
        {
            CashContext cc;
            double totalPrice = 0d;
            cc = new CashContext("cashRetuen");
            totalPrice = cc.GetResult(700);
            Assert.AreEqual(500,totalPrice);
        }

        [TestMethod]
        public void cashRebateTest()
        {
            CashContext cc;
            double totalPrice = 0d;
            cc = new CashContext("cashRebate");
            totalPrice = cc.GetResult(700);
            Assert.AreEqual(560,totalPrice);
        }
    }
}
