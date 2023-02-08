using OpenQA.Selenium;

namespace Assessment.Pages
{
    public class ProductCardsPage
    {
        public readonly HeaderNav headerNav;
        public readonly ProductCardsPageMap Map;

        public ProductCardsPage(IWebDriver driver)
        {
            Map = new ProductCardsPageMap(driver);
            headerNav = new HeaderNav(driver);
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

        public void ClickProductByName(string productName)
        {
            Map.Products(productName).Click();
        }
    }

    public class ProductCardsPageMap
    {
        IWebDriver _driver;

        public ProductCardsPageMap(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement ProductCards => _driver.FindElement(By.XPath("//div[@data-ref='product-card']"));

        //public IWebElement Products(string name) => _driver.FindElement(By.CssSelector($"a[href*='{name}']"));

        public IWebElement Products(string name) => _driver.FindElement(By.XPath($"//img[@alt='{name}']"));
    }
}

