using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SwagProject.Locators
{
    internal class check
    {
        public static By checkoutbtn = By.XPath("//button[@id='checkout']");
        public static By checkOutFirstName = By.XPath("//input[@id='first-name']");
        public static By checkOutLastName = By.XPath("//input[@id='last-name']");
        public static By checkOutPostalCode = By.XPath("//input[@id='postal-code']");
        public static By continueCheckOut = By.XPath("//input[@id='continue']");
    }
}
