using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormedixTest.Pages
{
    public class HomeScreen
    {
        IWebDriver driver;

        public HomeScreen(IWebDriver _driver)
        {
            driver = _driver;

        }

        public void NavigateToStudies()
        {
            IWebElement navRepository = driver.FindElement(By.CssSelector(".fdx-main-nav-item > .fdx-repository"));

            //Creating object of an Actions class
            Actions action = new Actions(driver);

            //Performing the mouse hover action on the target element.
            action.MoveToElement(navRepository).Perform();

            IWebElement navStudies = driver.FindElement(By.CssSelector("#menuMdbStudies .fdx-sub-nav-menu-item-desc"));
            navStudies.Click();

        }

        public void NavigateToViewTechStudy()
        {
            IWebElement ListItemMenuToggle = driver.FindElement(By.Id("fdxMdbContainerListItem0MenuToggle"));
            IWebElement ListItemView = driver.FindElement(By.Id("fdxMdbContainerListItem0View"));

            ListItemMenuToggle.Click();
            ListItemView.Click();

        }


    }
}

