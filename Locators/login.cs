using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SwagProject.Locators
{
    internal class login
    {
        public static By usernameField = By.XPath("//input[@id='user-name']");
        public static By passwordField = By.XPath("//input[@id='password']");
        public static By loginButton = By.XPath("//input[@id='login-button']");
        public static By homePageLogo = By.XPath("//div[@class='app_logo']");
    }
}
