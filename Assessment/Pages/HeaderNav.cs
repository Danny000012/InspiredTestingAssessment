using OpenQA.Selenium;

namespace Assessment.Pages
{
    public class HeaderNav
    {
        public readonly HeaderNavMap Map;

        public HeaderNav(IWebDriver driver)
        {
            Map = new HeaderNavMap(driver);
        }

        public void GotoValentinesTab()
        {
            Map.ValentinesTab.Click();
        }
    }

    public class HeaderNavMap
    {
        IWebDriver _driver;

        public HeaderNavMap(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement SearchItem => _driver.FindElement((By.XPath("//input[@name='search']")));

        public IWebElement searchSubmit => _driver.FindElement(By.XPath("//button[@data-ref='search-submit-button']"));

        public IWebElement ValentinesTab => _driver.FindElement(By.XPath("//a[@id='nav_item_368']"));
    }
}

