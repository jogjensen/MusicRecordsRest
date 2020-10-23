﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace MusicRecordsRestTests1.FrontEndTesting
{

    [TestClass()]
    public class FrontEndTest
    {

        //Googledriver
        //private static readonly string DriverDirectory = "C:\\BrowserDrivers\\Google";

        //Firefox driver
        private static readonly string DriverDirectory = "C:\\BrowserDrivers\\FireFox";


        private static IWebDriver _driver;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            //_driver = new ChromeDriver(DriverDirectory);
            _driver = new FirefoxDriver(DriverDirectory);
        }


        [TestMethod]
        public void TestAfTitel()
        {
            //_driver.Navigate().GoToUrl("https://drrecord.azurewebsites.net");
            _driver.Navigate().GoToUrl("http://localhost:3000/");
            string title = _driver.Title;
            Assert.AreEqual("Hello app",title);

//            WebDriverWait wait = new WebDriverWait();
        }

        [ClassCleanup]
        public static void TearDown()
        {
            _driver.Dispose();
        }

        [TestMethod]
        public void TestAfArtist()
        {                             
            //_driver.Navigate().GoToUrl("https://drrecord.azurewebsites.net");
            _driver.Navigate().GoToUrl("http://localhost:3000/");

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement Records = wait.Until(d => d.FindElement(By.Id("recordId")));
            Assert.IsTrue(Records.Text.Contains("AC/DC"));
            
        }

    }
}
