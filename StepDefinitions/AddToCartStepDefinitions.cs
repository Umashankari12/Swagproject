using System;
using OpenQA.Selenium;
using SwagProject.Pages;
using TechTalk.SpecFlow;

namespace SwagProject.StepDefinitions
{
    [Binding]
    public class AddToCartStepDefinitions
    {
       /* private readonly ScenarioContext scenarioContext;
        private IWebDriver driver;
        private LoginPage lp;*/
         AddToCart cart;

        public AddToCartStepDefinitions()
        {
            /*scenarioContext = scenarioContext;
            driver = scenarioContext["WebDriver"] as IWebDriver;
            lp = new LoginPage(driver);*/
            cart = new AddToCart();
        }

        [Given(@"User is on login page")]
        public void GivenUserIsOnLoginPage()
        {/*
            lp.launchbrowser();
            lp.enterusernamepass("standard_user", "secret_sauce");
            lp.login();*/
            Console.WriteLine("");
        }

        [When(@"User clicks the products")]
        public void WhenUserClicksTheProducts()
        {
            cart.productclick();
            Thread.Sleep(1000); 
        }

        [When(@"User clicks add to cart button")]
        public void WhenUserClicksAddToCartButton()
        {
            cart.AddCart();
            Thread.Sleep(1000);
        }

        [When(@"User clicks Cart Icon")]
        public void WhenUserClicksCartIcon()
        {
            cart.CartIcon();
            Thread.Sleep(1000);
        }

        [Then(@"Item added to cart should display")]
        public void ThenItemAddedToCartShouldDisplay()
        {
            Console.WriteLine("cart item displayed");
        }
    }
}
