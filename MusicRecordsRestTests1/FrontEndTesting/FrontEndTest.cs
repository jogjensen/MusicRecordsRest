using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace MusicRecordsRestTests1.FrontEndTesting
{

    [TestClass()]
    public class FrontEndTest
    {
        private static readonly string DriverDirectory = "C:\\BrowserDrivers\\Google";
        private static IWebDriver _driver;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _driver = new ChromeDriver(DriverDirectory);
        }


        [TestMethod]
        public void TestAfTitel()
        {
            _driver.Navigate().GoToUrl("https://drrecord.azurewebsites.net");
            string title = _driver.Title;
            Assert.AreEqual("Hello app",title);

//            WebDriverWait wait = new WebDriverWait();
        }

        [TestMethod]
        public void TestAfArtist()
        {

            _driver.Navigate().GoToUrl("https://drrecord.azurewebsites.net");

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement Records = wait.Until(d => d.FindElement(By.Id("records")));
            Assert.IsTrue(Records.Text.Contains("AC/DC"));
        }

    }
}
