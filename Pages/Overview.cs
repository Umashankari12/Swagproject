//using OpenQA.Selenium;

//namespace SwagProject.Pages
//{
//    internal class Overview
//    {
//        private readonly IWebDriver driver;

//        public Overview(IWebDriver driver)
//        {
//            this.driver = driver;
//        }

//        // Locator
//        private readonly By finishButton = By.XPath("//button[@id='finish']");

//        public void ClickFinish()
//        {
//            driver.FindElement(finishButton).Click();
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SwagProject.Locators;

namespace SwagProject.Pages
{
    internal class Overview
    {
        IWebDriver driver = SwagProject.Hooks.Hooks.driver;

        /* public Overview()
         {


         }*/

        //By finishButton = By.XPath("//button[@id='finish']");

        public void finish()
        {
            driver.FindElement(Complete.finishButton).Click();
            Thread.Sleep(1000);

        }
        public void confirmationPage()
        {
            string actualText = driver.FindElement(Complete.confirmationMessage).Text;
            Assert.That(actualText, Is.EqualTo("Thank you for your order!"));
        }
    }
}
