using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormedixTest.Pages
{
    public class TechStudyScreen
    {
        IWebDriver driver;

        public TechStudyScreen(IWebDriver _driver)
        {
            driver = _driver;

        }

        public void ClickDataAcquisition()
        {
            IWebElement BtnDataAcuisition = driver.FindElement(By.Id("dataAcquisitionType"));

            BtnDataAcuisition.Click();

        }
    }
}
