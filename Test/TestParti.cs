using System;
using AppLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class TestParti
    {
        [DataRow(null)]
        [DataRow("")]
        [DataRow("aaa")]
        [DataTestMethod]
        public void TestMethod1(string nom, string representant, string description)
        {
            Partis p = new Partis();
            Assert.IsNotNull(nom);
            Assert.IsNotNull(representant);
            Assert.IsNotNull(description);
        }
    }
}
