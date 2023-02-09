using OpenQA.Selenium;

namespace Assessment.Pages
{
    public class ProductCardsPage
    {
        public readonly HeaderNav headerNav;
        public readonly CartPage cartPage;
        public readonly ProductCardsPageMap Map;

        public ProductCardsPage(IWebDriver driver)
        {
            Map = new ProductCardsPageMap(driver);
            headerNav = new HeaderNav(driver);
            cartPage = new CartPage(driver);
        }

        public ProductCardsPage Goto()
        {
            headerNav.GotoValentinesTab();
            return this;
        }

        public IWebElement GetProductByName(string productName)
        {
            if (productName.Contains(" "))
            {
                productName.Replace(" ", "");
            }
            
            return Map.Products(productName);
        }

        public void FindProductByName(string productName)
        {
            Map.Products(productName);
        }

        public void ClickItemByName(string itemName)
        {
            Map.Cookie.Click();
            Map.Item(itemName).Click();
        }
    }

    public class ProductCardsPageMap
    {
        IWebDriver _driver;

        public ProductCardsPageMap(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement Products(string name) => _driver.FindElement(By.XPath($"//img[@alt='{name}']"));

        public IWebElement Item(string name) => _driver.FindElement(By.CssSelector($"a[href*='{name}']"));

        public IWebElement Cookie => _driver.FindElement(By.XPath("//button[@class='button cookies-banner-module_dismiss-button_24Z98']"));
    }
}

