//using OpenQA.Selenium;

//namespace SwagProject.Pages
//{
//    internal class AddToCart
//    {
//        private readonly IWebDriver driver;

//        public AddToCart(IWebDriver driver)
//        {
//            this.driver = driver;
//        }

//        // Locators
//        private readonly By product = By.XPath("//img[@alt='Sauce Labs Backpack']");
//        private readonly By addToCartBtn = By.XPath("//button[contains(@id, 'add-to-cart')]");
//        private readonly By cartIcon = By.XPath("//a[@class='shopping_cart_link']");

//        public AddToCart SelectProduct()
//        {
//            driver.FindElement(product).Click();
//            return this;
//        }

//        public AddToCart ClickAddToCart()
//        {
//            driver.FindElement(addToCartBtn).Click();
//            return this;
//        }

//        public Checkout ClickCartIcon()
//        {
//            driver.FindElement(cartIcon).Click();
//            return new Checkout(driver);
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SwagProject.Locators;

namespace SwagProject.Pages
{
    internal class AddToCart
    {
        IWebDriver driver = SwagProject.Hooks.Hooks.driver;

        /*public AddToCart(IWebDriver driver)
        {

            this.driver = driver;
        }*/
        //locators on addtocart page

        //By clickproduct = By.XPath("//img[@alt='Sauce Labs Backpack']");
        //By addtocartbtn = By.XPath("//button[contains(@id, 'add-to-cart')]");

        //By carticon = By.XPath("//a[@class='shopping_cart_link']");

        public void productclick()
        {
            driver.FindElement(Addcart.clickproduct).Click();
            Thread.Sleep(2000);

        }
        public void AddCart()
        {
            driver.FindElement(Addcart.addtocartbtn).Click();
            Thread.Sleep(2000);
        }
        public void CartIcon()
        {
            driver.FindElement(Addcart.carticon).Click();
            Thread.Sleep(1000);
        }
    }
}
