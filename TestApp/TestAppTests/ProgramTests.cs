using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void MinTest()
        {
            Assert.AreEqual(1,Program.Min(1,2,3));
        }

    }
}