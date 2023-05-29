using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormedixTest.Pages
{
    public class FormsViewScreen
    {
        IWebDriver driver;

        public FormsViewScreen(IWebDriver _driver)
        {
            driver = _driver;

        }

        public void ClickMedicalHistory()
        {
            IWebElement BtnForms = driver.FindElement(By.XPath("//div[4]/div/div"));

            BtnForms.Click();
        }

        public void ClickEditButton()
        {
            IWebElement BtnEdit = driver.FindElement(By.CssSelector("#switchEditMode > span:nth-child(2)"));

            BtnEdit.Click();
        }

        /// <summary>
        /// This method is to edit the description text area and validate that it has been updated.
        /// </summary>
        /// <param name="description">Description value to update the text area</param>
        public void EditDescriptionField(string description)
        {
            IWebElement TxtDescriptionField = driver.FindElement(By.Id("assetLocaleEditTextTextareadescription"));
            IWebElement TxtMainDescriptionField = driver.FindElement(By.CssSelector("#formDescription > span"));
            IWebElement BtnUpdate = driver.FindElement(By.Id("saveAsset"));
            IWebElement CloseEdit = driver.FindElement(By.Id("switchEditMode"));

            TxtDescriptionField.Click();
            TxtDescriptionField.Clear();
            TxtDescriptionField.SendKeys(description);

            //Sometimes the Update button is enabled and sometime it is disabled. This IF statement is to cater for both scenarios
            if(BtnUpdate.Enabled)
                BtnUpdate.Click();

            CloseEdit.Click();

            IWebElement DescriptionTextArea = driver.FindElement(By.XPath("//div[@id='descriptionValue']/div/div"));

            //The text area has a predefined 'default' text infront of the description value, We are only validating the description that was updated.
            int findFirstSpace = DescriptionTextArea.Text.IndexOf(' ');
            string DescriptionFieldValue = DescriptionTextArea.Text.Substring(findFirstSpace + 1).TrimStart();

            Assert.That(DescriptionFieldValue, Is.EqualTo(description), "The description field has not been updated");
            Assert.That(TxtMainDescriptionField.Text, Is.EqualTo(description), "The main description field has not been updated");
        }

        /// <summary>
        /// Logout of the application
        /// </summary>
        public void LogOut()
        {
            IWebElement UserIcon = driver.FindElement(By.CssSelector("#menuUser .fdx-main-nav-item"));
            IWebElement BtnLogOut = driver.FindElement(By.CssSelector("#formDescription > span"));

            //Creating object of an Actions class
            Actions action = new Actions(driver);

            //Performing the mouse hover action on the target element.
            action.MoveToElement(UserIcon).Perform();

            BtnLogOut.Click();
        }





    }
}
