using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NasonovaSV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.NasonovaSV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Света";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Света", res);
        }
    }
}
