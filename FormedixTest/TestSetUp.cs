using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace FormedixTest
{
    public class TestSetup
    {
        public IWebDriver driver;
        private readonly string browser = TestContext.Parameters["Browser"];

        [SetUp]
        public void Setup()
        {
            switch (browser)
            {
                case "FireFox":
                    driver = new FirefoxDriver();
                    break;
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                default:
                    Assert.Fail("No value for browser, Please check runsettings file.");
                    break;
            }

            driver.Url = TestContext.Parameters["URL"];
            driver.Manage().Window.Maximize(); //Maximize open window

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60); //Set global wait for WebDriver instance
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
