using OpenQA.Selenium;

namespace Assessment.Pages
{
    public class CartPage
    {
        public readonly CartPageMap Map;

        public CartPage(IWebDriver driver)
        {
            Map = new CartPageMap(driver);
        }

        public void AddProductToCart()
        {
            Map.BtnAddToCart.Click();
        }

        public void GoToCart()
        {
            Map.BtnGoToCart.Click();
        }

        public void OrderProductHeader()
        {
            var k = Map.OrderItemHeader.Text.ToString();
        }
    }

    public class CartPageMap
    {
        IWebDriver _driver;

        public CartPageMap(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement BtnAddToCart => _driver.FindElement((By.CssSelector("a[data-ref*='add-to-cart-button']")));
        public IWebElement BtnGoToCart => _driver.FindElement(By.XPath("//button[@class='button checkout-now dark']"));
        public IWebElement OrderItemHeader => _driver.FindElement(By.XPath("//h3[@class='cart-item-module_item-title_1M9cq']"));
    }
}

