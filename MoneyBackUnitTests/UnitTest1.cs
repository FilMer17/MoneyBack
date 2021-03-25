using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoneyBack;

namespace MoneyBackUnitTests
{
    [TestClass]
    public class MoneyBackTests
    {
        [TestMethod]
        public void NotEnoughMoney()
        {
            int given = 100;
            int pay = 200;

            string output = Program.ReturnCoins(given, pay);
            Assert.AreEqual("Málo peněz", output);
        }

        [TestMethod]
        public void ExactlyMoney()
        {
            int given = 200;
            int pay = 200;

                string output = Program.ReturnCoins(given, pay);
            Assert.AreEqual("Nic nevracet", output);
        }

        [TestMethod]
        public void ReturnOnGiven200OnPay37()
        {
            int given = 200;
            int pay = 37;

            string output = Program.ReturnCoins(given, pay);
            Assert.AreEqual("3x 50Kc minci\n1x 10Kc minci\n1x 2Kc minci\n1x 1Kc minci\n", output);
        }
    }
}
