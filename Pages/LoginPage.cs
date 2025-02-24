//using OpenQA.Selenium;

//namespace SwagProject.Pages
//{
//    internal class LoginPage
//    {
//        private readonly IWebDriver driver;

//        public LoginPage(IWebDriver driver)
//        {
//            this.driver = driver;
//        }

//        // Locators
//        private readonly By usernameField = By.XPath("//input[@id='user-name']");
//        private readonly By passwordField = By.XPath("//input[@id='password']");
//        private readonly By loginButton = By.XPath("//input[@id='login-button']");

//        public LoginPage LaunchBrowser()
//        {
//            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
//            return this; // Returning same page object for chaining
//        }

//        public LoginPage EnterUsernameAndPassword(string username, string password)
//        {
//            driver.FindElement(usernameField).SendKeys(username);
//            driver.FindElement(passwordField).SendKeys(password);
//            return this;
//        }

//        public AddToCart ClickLogin()
//        {
//            driver.FindElement(loginButton).Click();
//            return new AddToCart(driver); // Redirecting to AddToCart page
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium;


//namespace SwagProject.Pages
//{
//    internal class LoginPage
//    {
//        IWebDriver driver = SwagProject.Hooks.Hooks.driver;

//        /*public LoginPage()
//        {

//            this.driver =;
//        }*/

//        // locators on the login page

//        By usernameField = By.XPath("//input[@id='user-name']");
//        By passwordField = By.XPath("//input[@id='password']");
//        By loginFormLocator = By.XPath("//input[@id='login-button']");
//        By homepagedisplayed = By.XPath("//div[@class='app_logo']");



//        // laucnh browser

//        public void launchbrowser()
//        {
//            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

//        }

//        // enter username and password

//        public void enterusernamepass(String username, String password)
//        {

//            driver.FindElement(usernameField).SendKeys(username);
//            driver.FindElement(passwordField).SendKeys(password);

//        }
//        public void login()
//        {

//            driver.FindElement(loginFormLocator).Click();

//        }

//        // home page is displayed

//        public void homepagedisplay()
//        {


//            IWebElement homepage = driver.FindElement(homepagedisplayed);

//            if (homepage.Displayed)
//            {
//                Console.WriteLine("Home page is displayed");
//            }
//            else
//            {

//                Console.WriteLine("Home page is not displayed");
//            }
//        }
//    }
//}

using OpenQA.Selenium;
using SwagProject.Locators;

namespace SwagProject.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;

        // ✅ Fix: Pass WebDriver through constructor
        public LoginPage(IWebDriver driver)
        {
            if (driver == null)
            {
                throw new ArgumentNullException(nameof(driver), "WebDriver instance is null.");
            }
            this.driver = driver;
        }

        // Locators
        //private readonly By usernameField = By.XPath("//input[@id='user-name']");
        //private readonly By passwordField = By.XPath("//input[@id='password']");
        //private readonly By loginButton = By.XPath("//input[@id='login-button']");
        //private readonly By homePageLogo = By.XPath("//div[@class='app_logo']");

        // ✅ Fix: Ensure WebDriver is initialized before navigating
        public void LaunchBrowser()
        {
            if (driver == null)
            {
                throw new NullReferenceException("WebDriver is not initialized before calling LaunchBrowser().");
            }
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        public void EnterUsernameAndPassword(string username, string password)
        {
            driver.FindElement(login.usernameField).SendKeys(username);
            driver.FindElement(login.passwordField).SendKeys(password);
        }

        public void Login()
        {
            driver.FindElement(login.loginButton).Click();
        }

        public bool IsHomePageDisplayed()
        {
            return driver.FindElement(login.homePageLogo).Displayed;
        }
    }
}
