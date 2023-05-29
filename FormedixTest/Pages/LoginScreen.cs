using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormedixTest.Pages
{
    public class LoginScreen
    {
        IWebDriver driver;

        public LoginScreen(IWebDriver _driver)
        {
            driver = _driver;

        }

       /// <summary>
       /// Login method. The username and password are saved in the QA_Env runsettings file. This is cater for different environments the test scripts are executed and also for use if the scripts are executed in a CI/CD platform like Azure DevOps.
       /// </summary>
        public void Login()
        {
            IWebElement TxtUsername = driver.FindElement(By.Id("username"));
            IWebElement TxtPassword = driver.FindElement(By.Id("password"));
            IWebElement BtnSubmit = driver.FindElement(By.Id("btnSubmit"));

            TxtUsername.SendKeys(TestContext.Parameters["Username"]);
            TxtPassword.SendKeys(TestContext.Parameters["Password"]);

            BtnSubmit.Click();

        }
    }
}
