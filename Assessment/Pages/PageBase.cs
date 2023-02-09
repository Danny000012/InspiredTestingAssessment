using OpenQA.Selenium;

namespace Assessment.Pages
{
    public abstract class PageBase
    {
        public readonly HeaderNav headerNav;
        public readonly ProductCardsPage productCardsPage;
        public readonly CartPage cartPage;
        public PageBase(IWebDriver driver)
        {
            headerNav = new HeaderNav(driver);
            productCardsPage = new ProductCardsPage(driver);
            cartPage = new CartPage(driver);
        }
    }
}