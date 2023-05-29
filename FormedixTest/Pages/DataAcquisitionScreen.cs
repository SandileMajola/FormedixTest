using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormedixTest.Pages
{
    public  class DataAcquisitionScreen
    {
        IWebDriver driver;

        public DataAcquisitionScreen(IWebDriver _driver)
        {
            driver = _driver;

        }

        public void ClickAssetForms()
        {
            IWebElement BtnForms = driver.FindElement(By.Id("FORMCount"));

            BtnForms.Click();

        }
    }
}
