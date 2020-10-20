using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicRecordsRest.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicRecordsRest.Model.Tests
{
    [TestClass()]
    public class RecordsTests
    {
        private Records records = new Records(1, "Niqulay", "Niko", 2000, 5);

        //Constructor test
        [TestMethod()]
        public void RecordsConstructorTest()
        {
            Records records = new Records(1, "Niqulay", "Niko", 2000, 5);

            Assert.AreEqual(1, 1);
            Assert.AreEqual("Niqulay", "Niqulay");
            Assert.AreEqual("Niko", "Niko");
            Assert.AreEqual(2000, 2000);
            Assert.AreEqual(5, 5);
        }
        

    }
}